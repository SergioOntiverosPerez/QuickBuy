﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        
        /// <summary>
        /// Un usuario puede tener ningun o muchos pedidos
        /// </summary>

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email no fue informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Contraseña no fue informada");
        }
    }
}
