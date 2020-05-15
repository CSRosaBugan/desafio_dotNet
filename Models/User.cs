using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace desafio.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "este campo  obrigatrio")]
        public string name { get; set; }  
        public string email { get; set; }
        public string senha { get; set; }
        public List<Telefone> telefones { get; set;}
        public DateTime data_criacao { get; set; }
        public DateTime data_atualizacao { get; set; }
        public DateTime ultimo_login { get; set; }
        
    }
    
}