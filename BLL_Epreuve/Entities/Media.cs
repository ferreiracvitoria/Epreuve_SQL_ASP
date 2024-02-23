using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class Media
    {
        private string _urlImage;
        private List<Media> _medias;
        public int Id_Media { get; private set; }
        public int Id_Produit { get; private set; }

        public string UrlImage
        {
            get
            {
                return _urlImage;
            }
            private set
            {
                _urlImage = value;
            }
        }

        public Media (int id_media, int id_produit, string urlImage)
        {
            Id_Media = id_media;
            Id_Produit = id_produit;
            UrlImage = urlImage;
        }

        public Media[] Medias
        {
            get
            {
                return _medias.ToArray() ?? new Media[0];
            }
        }
    }
}

