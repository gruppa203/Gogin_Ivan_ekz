//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gogin203Ekz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sklad
    {
        public string Cod_tovara { get; set; }
        public string ed_izm { get; set; }
        public string Cena { get; set; }
        public string Skidka_max { get; set; }
        public string Skidka_dei { get; set; }
        public int Col_na_sklade { get; set; }
    
        public virtual Naim_Opis Naim_Opis { get; set; }
    }
}
