using System.Configuration;

namespace HostsSwitcher
{
    public class HostsSwitcherConfiguration : ConfigurationSection
    {
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
        protected override ConfigurationElement CreateNewElement()
        {
            return new HostElement();
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
        }

        [ConfigurationProperty("ip", IsRequired = true)]
        public string IP
        {
            get { return this["ip"] as string; }
        }
    }

    [ConfigurationCollection(typeof(HostEntryElement), AddItemName = "HostEntry", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class HostEntryElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new HostEntryElement();
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
        }
    }
}
