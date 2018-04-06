namespace AdministrareAsociatie
{
    internal class ConturiBancareDataSetTableAdapters
    {
        internal class ConturiBancareTableAdapter
        {
            public ConturiBancareTableAdapter()
            {
            }

            public bool ClearBeforeFill { get; internal set; }
        }

        internal class TableAdapterManager
        {
            public TableAdapterManager()
            {
            }

            public static object UpdateOrderOption { get; internal set; }
            public bool BackupDataSetBeforeUpdate { get; internal set; }
            public ConturiBancareTableAdapter ConturiBancareTableAdapter { get; internal set; }
            public object UpdateOrder { get; internal set; }
        }
    }
}