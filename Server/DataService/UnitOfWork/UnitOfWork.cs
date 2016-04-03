using Database_Entities;
using DataService.Repository;

namespace DataLayer.Logic.Database.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly object _db;

        private GenericRepository<User> _userRepository;
        private GenericRepository<Company> _companyRepository;
        private GenericRepository<PersonalLetter> _personalLetter;
        public UnitOfWork(object db)
        {
            _db = db;
        }

        public GenericRepository<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new GenericRepository<User>(_db);
                }
                return _userRepository;
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

    }
}