﻿

namespace RestApiModeloDDD.Domain.Entitys
{
    public class Produto : Base
    {
        public decimal Valor { get; set; }
        public bool IsDisponivel { get; set; }
    }
}
