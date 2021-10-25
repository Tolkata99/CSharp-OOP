 namespace P01.Stream_Progress
{
    public class File : IStreamable
    {
        private string name;

        public File(string name, int length, int bytesSent)
        {
            this.name = name;
            this.Length = length;
            this.ByteSent = bytesSent;
        }

        public int Length { get; set; }

        public int ByteSent { get; set; }
    }
}
