﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities {
    class Client {

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; } // nascimento

        public Client() {

        }

        public Client(string name, string email, DateTime date) {
            Name = name;
            Email = email;
            BirthDate = date;

        }

        public override string ToString() {
            return $"{Name}, ( {BirthDate.ToString("dd/MM/yyyy")}) - {Email}";
        }
    }
}
