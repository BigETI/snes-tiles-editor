using MetroTranslatorStyler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;

namespace SNESTilesEditor
{
    class TranslatorStylerInterface : ITranslatorStylerInterface
    {
        private Language[] languages = new Language[] { new Language("ENGLISH", "en-GB"), new Language("GERMAN", "de-DE") };

        public string Language
        {
            get
            {
                return Properties.Settings.Default.Language;
            }
            set
            {
                Properties.Settings.Default.Language = value;
            }
        }

        public string AssemblyName
        {
            get
            {
                return "SNESTilesEditor";
            }
        }

        public IEnumerable<Language> Languages
        {
            get
            {
                return languages;
            }
        }

        public MetroThemeStyle UseTheme
        {
            get
            {
                return Properties.Settings.Default.UseTheme;
            }
            set
            {
                Properties.Settings.Default.UseTheme = value;
            }
        }

        public MetroColorStyle UseStyle
        {
            get
            {
                return Properties.Settings.Default.UseStyle;
            }
            set
            {
                Properties.Settings.Default.UseStyle = value;
            }
        }

        public void SaveSettings()
        {
            throw new NotImplementedException();
        }
    }
}
