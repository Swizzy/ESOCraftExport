namespace ESOCraftExport {
    using System.Drawing;
    using System.Windows.Forms;

    internal sealed class CustomListBox: ListBox {
        public CustomListBox() { SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true); }

        protected override void OnDrawItem(DrawItemEventArgs e) {
            if(e.Index < 0)
                return;
            e.DrawBackground();
            var color = Color.Red;
            if (((CustomListBoxItem)Items[e.Index]).Value)
                color = Color.Green;
            TextRenderer.DrawText(e.Graphics, Items[e.Index].ToString().Trim(), e.Font, e.Bounds, color, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }

        protected override void OnPaint(PaintEventArgs e) {
            for(var i = 0; i < Items.Count; i++) {
                var itemRect = GetItemRectangle(i);
                if(!e.ClipRectangle.IntersectsWith(itemRect))
                    continue;
                var diea = SelectedIndices.Contains(i)
                               ? new DrawItemEventArgs(e.Graphics, Font, itemRect, i, DrawItemState.Selected) : new DrawItemEventArgs(e.Graphics, Font, itemRect, i, DrawItemState.None);
                OnDrawItem(diea);
            }
        }

        public class CustomListBoxItem {
            private readonly string _name;
            internal readonly bool Value;

            public CustomListBoxItem(string name, bool value) {
                Value = value;
                _name = name;
            }

            public override string ToString() { return _name; }
        }
    }
}