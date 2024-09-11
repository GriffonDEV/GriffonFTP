using Renci.SshNet;


namespace SubirFTP.Logica
{
    internal class subida
    {
        public  String subirPBO(FileInfo prmFileinfo)
        {
            string host = "arma.griffoncol.great-site.net";
            string username = "steam";
            string password = "Arma3Gfn";

            string uploadfile = prmFileinfo.FullName;
            Console.WriteLine(prmFileinfo.Name);
            Console.WriteLine("uploadfile" + uploadfile);

            //Passing the sftp host without the "sftp://"
            var client = new SftpClient(host, username, password);
            try
            {
                client.Connect();
                var fileStream = new FileStream(uploadfile, FileMode.Open);
                        //If you have a folder located at sftp://ftp.example.com/share
                        //then you can add this like:
                        client.UploadFile(fileStream, "/home/steam/arma3gfn/mpmissions/" + prmFileinfo.Name, null);
                        client.Disconnect();
                        client.Dispose();
                        return "Subido.";

            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }
            

        }

        public String subirSSH(FileInfo prmFileinfo)
        {
            string host = "arma.griffoncol.great-site.net";
            string username = "steam";
            string password = "Arma3Gfn";

            string uploadfile = prmFileinfo.FullName;
            Console.WriteLine(prmFileinfo.Name);
            Console.WriteLine("uploadfile" + uploadfile);

            //Passing the sftp host without the "sftp://"
            var client = new SftpClient(host, username, password);
            try
            {
                client.Connect();
                var fileStream = new FileStream(uploadfile, FileMode.Open);
                //If you have a folder located at sftp://ftp.example.com/share
                //then you can add this like:
                client.UploadFile(fileStream, "/home/steam/arma3gfn/" + prmFileinfo.Name, null);
                client.Disconnect();
                client.Dispose();
                return "Subido.";

            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }

        }


    }
}
