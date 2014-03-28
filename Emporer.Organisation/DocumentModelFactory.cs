using System.IO;

namespace OpenResKit.Organisation
{
  public static class DocumentModelFactory
  {
    public static Document CreateDocument(string name, Stream stream)
    {
      byte[] byteArray;
      using (var br = new BinaryReader(stream))
      {
        byteArray = br.ReadBytes((int) stream.Length);
      }

      return new Document()
             {
               DocumentSource = new DocumentSource()
                                {
                                  BinarySource = byteArray
                                },
               Name = name
             };
    }
    
  }
}