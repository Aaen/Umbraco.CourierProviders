namespace DisPlay.Umbraco.CourierProviders.Core.Grid
{
    using System;

    using global::Umbraco.Courier.Core;
    using global::Umbraco.Courier.DataResolvers.PropertyDataResolvers;
    using global::Umbraco.Courier.ItemProviders;

    public class DoctypeGridEditorGridCellDataResolverProvider : GridCellDataResolverProvider
    {
        public override bool ShouldRun(string view, dynamic cell)
        {
            try
            {
                return cell?.editor?.alias?.ToString() == "docType";
            }
            catch
            {
                // ignored
            }

            return false;
        }

        public override void PackagingCell(Item item, ContentProperty propertyData, dynamic cell)
        {
        }
    }
}
