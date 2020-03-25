using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootStrapHotelMVCMySql.Models
{
    public class Funcionarios
    {
        // Declarações dos Atributos
        public int Id { get; set; }
        
        [Required(ErrorMessage="Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Cargo é obrigatório")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone é obrigatório")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Foto é obrigatório")]
        public string Foto { get; set; }

        public Funcionarios()
        {
        }

        public Funcionarios(int id,
            string nome,
            string cargo,
            string email,
            string phone,
            string foto)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Cargo = cargo ?? throw new ArgumentNullException(nameof(cargo));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            foto = foto ?? throw new ArgumentNullException(nameof(foto));
            
        }
    }
}