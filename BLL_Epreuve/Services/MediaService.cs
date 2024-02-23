using BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Shared.Repositories;
using BLL_Epreuve.Mappers;

namespace BLL_Epreuve.Services
{
    public class MediaService : IMediaRepository<Media>
    {
        private readonly IMediaRepository<DAL.Media> _mediaRepository;

        public MediaService(IMediaRepository<DAL.Media> repository)
        {
            _mediaRepository = repository;
        }

        public IEnumerable<Media> Get()
        {
            return _mediaRepository.Get().Select(d => d.ToBLL());
        }
        public Media Get(int id)
        {
            return _mediaRepository.Get(id).ToBLL();
        }
        public int Insert(Media data)
        {
            return _mediaRepository.Insert(data.ToDAL());
        }
        public void Update(Media data)
        {
            _mediaRepository.Update(data.ToDAL());
        }
        public void Delete(int id)
        {
            _mediaRepository.Delete(id);
        }
        public IEnumerable<Media> GetMediaForProduit(int id_produit)
        {
            return _mediaRepository.GetMediaForProduit(id_produit).Select(d => d.ToBLL());
        }
    }
}
