namespace ConsoleApplication_ExAula5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoDeNome : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tb_pedidos", newName: "pedidos");
            RenameTable(name: "dbo.tb_itenspedidos", newName: "itenspedidos");
            RenameTable(name: "dbo.tb_produtos", newName: "produtos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.produtos", newName: "tb_produtos");
            RenameTable(name: "dbo.itenspedidos", newName: "tb_itenspedidos");
            RenameTable(name: "dbo.pedidos", newName: "tb_pedidos");
        }
    }
}
