using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface ICampaingService
    {
        void Save(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
        void Start(Campaing campaing);
        void Finish(Campaing campaing);
        void About(Campaing campaing);
    }
}