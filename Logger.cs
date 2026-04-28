namespace AbstractFactory
{
    
    public class Logger
    {

        private static Logger CreateLogger()
        {
            
            return new Logger();

        }
        private static readonly Lazy<Logger> instance = new Lazy<Logger>(CreateLogger);
        public static Logger Instance{ get{return instance.Value;} }

        private Logger(){}

        public string IsFileExists() //check if file exists, create if not, return file path
        {
            
            string loggerFile = Path.Combine(Directory.GetCurrentDirectory(), "Logs.txt");

            if (!File.Exists(loggerFile))
            {
                
                using(File.Create(loggerFile)){}

            }

            return loggerFile;

        }

        public void Log(string logText)
        {
            
            string filePath = IsFileExists();

            File.AppendAllText(filePath, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {logText}" + Environment.NewLine);

        }

    }

}