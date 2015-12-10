namespace ConsoleApplication_ExAula5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoRelacionamentos1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_pedidos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 255),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_itenspedidos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPedido = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_pedidos", t => t.IdPedido, cascadeDelete: true)
                .ForeignKey("dbo.tb_produtos", t => t.IdProduto, cascadeDelete: true)
                .Index(t => t.IdPedido)
                .Index(t => t.IdProduto);
            
            CreateTable(
                "dbo.tb_produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 255),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_itenspedidos", "IdProduto", "dbo.tb_produtos");
            DropForeignKey("dbo.tb_itenspedidos", "IdPedido", "dbo.tb_pedidos");
            DropIndex("dbo.tb_itenspedidos", new[] { "IdProduto" });
            DropIndex("dbo.tb_itenspedidos", new[] { "IdPedido" });
            DropTable("dbo.tb_produtos");
            DropTable("dbo.tb_itenspedidos");
            DropTable("dbo.tb_pedidos");
        }
    }
}
