namespace Bussiness
{
    public class Backup
    {
        public void Generatebackup(string path)
        {
            new Database.Backup().Generatebackup(path);
        }
    }
}
