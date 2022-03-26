using System;
using OOPProject.SourceFiles.Repositories.Models;
using SQLite;

namespace OOPProject.SourceFiles.Repositories
{
    public class UsersRepository
    {
        private readonly SQLiteConnection _database;

        public UsersRepository()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "entities.db");
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<UserEntity>();
        }

        public List<UserEntity> List()
        {
            return _database.Table<UserEntity>().ToList();
        }

        public long Create(UserEntity entity)
        {
            return _database.Insert(entity);
        }

        public long Update(UserEntity entity)
        {
            return _database.Update(entity);
        }

        public long Delete(UserEntity entity)
        {
            return _database.Delete(entity);
        }
    }
}
