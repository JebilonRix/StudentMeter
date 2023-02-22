using Newtonsoft.Json;

namespace StudentMeter
{
    public static class SaveLoad
    {
        private static readonly string _saveFileStudentsPath = string.Format(@"{0}\save.json", Application.StartupPath);

        public static void Save()
        {
            //Converts dictionary members to json data.
            string jsonData = JsonConvert.SerializeObject(StudentMethods.Students);

            //Writes json data to the file.
            File.WriteAllText(_saveFileStudentsPath, jsonData);
        }

        public static void Load()
        {
            if (!File.Exists(_saveFileStudentsPath))
            {
                File.Create(_saveFileStudentsPath);
                return;
            }

            //Reads the save file.
            string jsonData = File.ReadAllText(_saveFileStudentsPath);

            //Converts the data which is in json to list.
            List<Student> listOfStudents = JsonConvert.DeserializeObject<List<Student>>(jsonData);

            //Null check
            if (listOfStudents == null)
            {
                return;
            }

            //Adds to all data to list.
            StudentMethods.Students.AddRange(listOfStudents);
        }
    }
}