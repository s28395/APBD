using System;

namespace LegacyApp
{
    public class UserService
    {
        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            if (!IsValidName(firstName, lastName) || !IsValidEmail(email) || !IsUserAdult(dateOfBirth))
            {
                return false;
            }

            var client = GetClientById(clientId);
            if (client == null)
            {
                return false;
            }

            var user = CreateUser(firstName, lastName, email, dateOfBirth, client);
            SetCreditLimit(user, client);

            if (IsInvalidCreditLimit(user))
            {
                return false;
            }

            UserDataAccess.AddUser(user);
            return true;
        }

        private bool IsValidName(string firstName, string lastName)
        {
            return !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName);
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        private bool IsUserAdult(DateTime dateOfBirth)
        {
            var age = CalculateAge(dateOfBirth);
            return age >= 21;
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) 
            {
                age--;
            }
            return age;
        }

        private Client GetClientById(int clientId)
        {
            var clientRepository = new ClientRepository();
            return clientRepository.GetById(clientId);
        }

        private User CreateUser(string firstName, string lastName, string email, DateTime dateOfBirth, Client client)
        {
            return new User
            {
                Client = client,
                DateOfBirth = dateOfBirth,
                EmailAddress = email,
                FirstName = firstName,
                LastName = lastName
            };
        }

        private void SetCreditLimit(User user, Client client)
        {
            var userCreditService = new UserCreditService();
            int creditLimit = userCreditService.GetCreditLimit(user.LastName, user.DateOfBirth);

            if (client.Type == ClientType.VeryImportantClient.ToString())
            {
                user.HasCreditLimit = false;
            }
            else
            {
                user.HasCreditLimit = true;
                creditLimit = client.Type == ClientType.ImportantClient.ToString() ? creditLimit * 2 : creditLimit;
                user.CreditLimit = creditLimit;
            }
        }

        private bool IsInvalidCreditLimit(User user)
        {
            return user.HasCreditLimit && user.CreditLimit < 500;
        }

        private enum ClientType
        {
            VeryImportantClient,
            ImportantClient,
            RegularClient
        }
    }
}
