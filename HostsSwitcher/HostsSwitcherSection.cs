using System;
using System.Configuration;
using System.Reflection;

namespace HostsSwitcher
{
    public class HostsSwitcherSection : ConfigurationSection
    {
        private static HostsSwitcherSection _instance = null;

        public static HostsSwitcherSection Open()
        {
            Assembly assembly = Assembly.GetEntryAssembly();
            return Open(assembly.Location);
        }

        public static HostsSwitcherSection Open(string path)
        {
            if (_instance == null)
            {
                if (path.EndsWith(".config", StringComparison.InvariantCultureIgnoreCase))
                    path = path.Remove(path.Length - 7);
                Configuration config = ConfigurationManager.OpenExeConfiguration(path);
                if (config.Sections["HostsSwitcherSection"] == null)
                {
                    _instance = new HostsSwitcherSection();
                    config.Sections.Add("HostsSwitcherSection", _instance);
                    config.Save(ConfigurationSaveMode.Modified);
                }
                else
                    _instance = (HostsSwitcherSection)config.Sections["HostsSwitcherSection"];
            }
            return _instance;
        }

        public void Save()
        {
            this.CurrentConfiguration.Save(ConfigurationSaveMode.Modified);
        }

        [ConfigurationProperty("Hosts")]
        public HostElementCollection Hosts
        {
            get { return (HostElementCollection)base["Hosts"]; }
        }

        [ConfigurationProperty("HostEntries")]
        public HostEntryElementCollection HostEntries
        {
            get { return (HostEntryElementCollection)base["HostEntries"]; }
        }
    }

    [ConfigurationCollection(typeof(HostElement), AddItemName="Host", CollectionType=ConfigurationElementCollectionType.BasicMap)]
    public class HostElementCollection : ConfigurationElementCollection
    {
        public HostElement this[int index]
        {
            get { return base.BaseGet(index) as HostElement; }
            set
            {
                if (index < base.Count && base.BaseGet(index) != null)
                    base.BaseRemoveAt(index);
                this.BaseAdd(index, value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new HostElement();
        }

        public void RemoveAt(int index)
        {
            this.BaseRemoveAt(index);
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((HostElement)element).Name;
        }

        new public HostElement this[string name]
        {
            get { return (HostElement)BaseGet(name); }
        }
    }

    public class HostElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return this["name"] as string; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("ip", IsRequired = true)]
        public string IP
        {
            get { return this["ip"] as string; }
            set { this["ip"] = value; }
        }
    }

    [ConfigurationCollection(typeof(HostEntryElement), AddItemName = "HostEntry", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class HostEntryElementCollection : ConfigurationElementCollection
    {
        public HostEntryElement this[int index]
        {
            get { return base.BaseGet(index) as HostEntryElement; }
            set
            {
                if (index < base.Count && base.BaseGet(index) != null)
                    base.BaseRemoveAt(index);
                this.BaseAdd(index, value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new HostEntryElement();
        }

        public void RemoveAt(int index)
        {
            this.BaseRemoveAt(index);
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((HostEntryElement)element).Name;
        }

        new public HostEntryElement this[string name]
        {
            get { return (HostEntryElement)BaseGet(name); }
        }
    }

    public class HostEntryElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return this["name"] as string; }
            set { this["name"] = value; }
        }
    }
}
