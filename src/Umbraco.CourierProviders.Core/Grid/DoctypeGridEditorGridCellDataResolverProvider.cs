namespace DisPlay.Umbraco.CourierProviders.Core.Grid
{
    using global::Umbraco.Courier.DataResolvers.PropertyDataResolvers;

    public class DoctypeGridEditorGridCellDataResolverProvider : GridCellDataResolverProvider
    {
        public override bool ShouldRun(string view, dynamic cell)
        {
            return false;
        }
    }
}
