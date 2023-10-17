using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace startaccademynet4;

class Car2
{
    [Required]  //annotation, id deve essere perforza dato
    [Key]       //annotation, questo ID è il corrispondente di una chiave
    [MaxLength(30)] //annotation, questo ID può avere lenght max a 30
    readonly int id ;
    [MinLength(2)] //annotation, permette al nome di avere almeno 2 caratteri
    readonly string name="";
    [DisplayName("anno di produzione dell'auto")]
    [Range(1960, 2023, ErrorMessage = "il valore deve esser cmpreso tra 1960 e 2023")]
    //annotation, permette a ProductionYear di essere solo in un certo Range
    int ProductionYear {get; set;}

    internal Car2(int id, string name){
        this.id = id;
        this.name = name;
    }
}

