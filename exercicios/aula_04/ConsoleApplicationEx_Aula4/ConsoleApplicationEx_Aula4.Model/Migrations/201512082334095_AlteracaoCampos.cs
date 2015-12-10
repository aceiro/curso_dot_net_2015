namespace ConsoleApplicationEx_Aula4.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoCampos : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pedidoes", newName: "tbl_pedido");
            AlterColumn("dbo.tbl_pedido", "Descricao", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_pedido", "Descricao", c => c.String());
            RenameTable(name: "dbo.tbl_pedido", newName: "Pedidoes");
        }
    }
}
