namespace Bussiness
{
    public class Backup
    {
        public void Generatebackup(string path)
        {
            new Database.Backup().Generatebackup(path);
        }
        
        public void RestoreDatabase(string path)
        {
            new Database.Backup().RestoreDatabase(path);
        }
    }
}
