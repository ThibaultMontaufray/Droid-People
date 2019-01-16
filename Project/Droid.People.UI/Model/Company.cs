using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;

namespace Droid.People
{
    public class ImageConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object result;
            try
            {
                var base64 = (string)reader.Value;
                // convert base64 to byte array, put that into memory stream and feed to image
                result =  System.Drawing.Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                result = null;
            }
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var image = (System.Drawing.Image)value;
            // save to memory stream in original format
            var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            byte[] imageBytes = ms.ToArray();
            // write byte array, will be converted to base64 by JSON.NET
            writer.WriteValue(imageBytes);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(System.Drawing.Image);
        }
    }
    public class Company : Entity
    {
        #region Attributes
        private double _siret;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "siret")]
        public double SIRET
        {
            get { return _siret; }
            set { _siret = value; }
        }
        #endregion

        #region Constructor
        public Company()
        {

        }
        #endregion

        #region Methods public
        public new object Clone()
        {
            Company c = new Company();
            c._siret = this._siret;
            c._name = this._name;
            c._mail = this._mail;
            return c;
        }
        public string GetName()
        {
            return string.Format("{0} {1}", _name, _siret);
        }
        public override string ToString()
        {
            return string.Format("{0}_{1}.peo", _name, _siret);
        }
        public new void Save()
        {
            string path = Path.Combine(InterfacePeople.WORKING_DIRECTORY, this.ToString());
            if (!string.IsNullOrEmpty(path))
            {
                FileInfo fi = new FileInfo(path);
                if (!Directory.Exists(fi.DirectoryName)) { Directory.CreateDirectory(path); }
                using (StreamWriter sw = new StreamWriter(path, false)) { sw.Write(ExportJson()); }
            }
        }
        #endregion

        #region Methods private
        private string ImageToString(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        private System.Drawing.Image StringToImage(byte[] img)
        {
            using (var ms = new MemoryStream(img))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
