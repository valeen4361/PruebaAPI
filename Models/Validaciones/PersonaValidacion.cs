using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaAPI.Models
{

    [MetadataType(typeof(persona.MetaData))] //relacion las reglas a los atributos de la entidad qeue se creo 
                                             //EntityFRamework
     public partial class persona 
    { 
        //clase sellada,para que no se pueda heredar 
        sealed class MetaData
        {
            [Required]
            public string Nombre;
        }
    }
}