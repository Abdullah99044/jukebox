﻿using jukebox.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace jukebox.Data
{
    public class seed
    {

        public static void seeding(IApplicationBuilder applicationBuilder)
        {
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {

                var db = servicescope.ServiceProvider.GetService<ApplicationDbContext>();


                //Genres 

                if (!db.Genres.Any())
                {

                    db.Genres.AddRange(new List<Genres>()
                    {

                        new Genres()
                        {
                            Name = "Lofi"

                        },

                        new Genres() {

                            Name = "Rap"

                        },

                        new Genres()
                        {

                            Name = "Pop"

                        },

                        new Genres()
                        {

                            Name = "Classic"

                        },

                        new Genres()
                        {

                            Name = "Countery"

                        }
                    });

                    db.SaveChanges();

                }

                //Songs

                if (!db.Songs.Any())
                {


                    db.Songs.AddRange(new List<Songs>()
                    {


                        // Lofi songs 

                        new Songs()
                        {

                            Name = "Studing-lofi",

                            Length = TimeSpan.FromMinutes(12),

                            Artist = "Lofi art" ,

                            GenresId = 1
                        },

                        new Songs()
                        {

                            Name = "Gaming-lofi",

                            Length = TimeSpan.FromMinutes(12),

                            Artist = "Lofi art" ,

                            GenresId = 1
                        },

                        new Songs()
                        {

                            Name = "Working-lofi",

                            Length = TimeSpan.FromMinutes(12),

                            Artist = "Lofi art" ,

                            GenresId = 1

                        },

                        //Rap songs 

                         new Songs()
                        {

                            Name = "Lose Yoirself",

                            Length = TimeSpan.FromMinutes(4),

                            Artist = "Eminem" ,

                            GenresId = 2
                        },

                        new Songs()
                        {

                            Name = "Till I Collapse ",

                            Length = TimeSpan.FromMinutes(4) + TimeSpan.FromSeconds(30) ,

                            Artist = "Eminem" ,

                            GenresId = 2
                        },

                        new Songs()
                        {

                            Name = "In da club",

                            Length = TimeSpan.FromMinutes(5),

                            Artist = "50 cent" ,

                            GenresId = 2

                        }

                    });
                    db.SaveChanges();




                }

 

                //Playlists

                if (!db.PlayLists.Any())
                {

                    db.PlayLists.AddRange(new List<PlayLists>()
                    {
                        new PlayLists()
                        {
                            Name = "Rap playlist",
                            UserId = "fa970c7f-7425-4bba-96bc-5502113f858b" 

                        },

                        new PlayLists()
                        {

                            Name = "Lofi playlist",
                            UserId = "fa970c7f-7425-4bba-96bc-5502113f858b"

                        }

                    });

                    db.SaveChanges();

                }

                //Saved songs

                if (!db.Saved_Songs.Any())
                {

                    db.Saved_Songs.AddRange(new List<Saved_Songs>()
                    {
                        new Saved_Songs()
                        {
                            SongsId = 1 ,
                            PlaylistId = 7  

                        },

                        new Saved_Songs()
                        {

                            SongsId = 2 ,
                            PlaylistId = 7

                        },

                        new Saved_Songs()
                        {
                             SongsId = 3 ,
                            PlaylistId = 7

                        },

                        

                    });

                    db.SaveChanges();

                }
 
            }

        }

           
    }

    
}
