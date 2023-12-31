﻿using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace jukebox.Models
{
    public class Songs
    {

        [Key]

        public int Id { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Artist { get; set; } = null!;

        [Required]
        public TimeSpan Length { get; set; }

 
        public int GenresId { get; set; }
        public Genres Genres { get; set; } = null!;

        public ICollection<Saved_Songs> Saved_Songs { get; set; }



    }
}
