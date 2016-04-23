using Database_Entities;
using DataService.Repository;

namespace DataService.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly object _db;

        private GenericRepository<Company> _companyRepository;
        private GenericRepository<PersonalLetter> _personalLetter;
        private GenericRepository<Admin> _adminsRepository;
        private GenericRepository<Technician> _technicianRepository;

        public UnitOfWork(object db)
        {
            _db = db;
        }

        public GenericRepository<Technician> TechnicianRepository
        {
            get
            {
                if (_technicianRepository == null)
                {
                    _technicianRepository = new GenericRepository<Technician>(_db);
                }
                return _technicianRepository;
            }
        }

        public GenericRepository<Company> CompanyRepository
        {
            get
            {
                if (_companyRepository == null)
                {
                    _companyRepository = new GenericRepository<Company>(_db);
                }
                return _companyRepository;
            }
        }

        public GenericRepository<PersonalLetter> PersonalLetterRepository
        {
            get
            {
                if (_personalLetter == null)
                {
                    _personalLetter = new GenericRepository<PersonalLetter>(_db);
                }
                return _personalLetter;
            }
        }

        public GenericRepository<Admin> AdminRepository
        {
            get
            {
                if (_adminsRepository == null)
                {
                    _adminsRepository = new GenericRepository<Admin>(_db);
                }
                return _adminsRepository;
            }
        }

    }
}