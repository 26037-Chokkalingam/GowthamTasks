namespace ReflectionLearning
{
    internal class SampleClass
    {
        public SampleClass() { }

        public SampleClass(string sampleName, string sampleDescription)
        {
            SampleName = sampleName;
            SampleDescription = sampleDescription;
        }

        public string SampleName { get; set; }

        private string SampleDescription { get; set; }

        public void Display()
        {
            Console.WriteLine($"{SampleDescription}");
        }


        private void ChangeDescription(string newDescription)
        {
            this.SampleDescription = newDescription;
        }


    }
}
