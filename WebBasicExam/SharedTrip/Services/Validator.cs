﻿using SharedTrip.Models.Trips;
using SharedTrip.Models.Users;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using static SharedTrip.Data.DataConstants;

namespace SharedTrip.Services
{
    public class Validator : IValidator
    {

        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < UserMinUsername || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username '{model.Username}' is not valid. It must be between {UserMinUsername} and {DefaultMaxLength} characters long.");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegularExpression))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address.");
            }

            if (model.Password.Length < UserMinPassword || model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"The provided password is not valid. It must be between {UserMinPassword} and {DefaultMaxLength} characters long.");
            }

            if (model.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot contain whitespaces.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add($"Password and its confirmation are different.");
            }

            return errors;
        }

        public ICollection<string> ValidateTrip(AddTripFromModel model)
        {
            var errors = new List<string>();

            if (model.Seats < TripMinSeats || model.Seats > TripMaxSeats)
            {
                errors.Add($"Seats must be between {UserMinUsername} and {DefaultMaxLength}.");
            }

            if (model.Description.Length > TripMaxDescription)
            {
                errors.Add($"Description cannot be longer that {TripMaxDescription} characters.");
            }
            
            return errors;
        }
    }
}
