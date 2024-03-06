using FluentMigrator;
namespace WebApplication4.Migrations;

[Migration(1)]
public class M0000_InitialMigration : Migration
{
    public override void Up()
    {
        Create.Table("hookahs")
            .WithColumn("id").AsInt64().PrimaryKey()
            .WithColumn("name").AsString()
            .WithColumn("description").AsString()
            .WithColumn("price").AsDouble()
            .WithColumn("count").AsInt64();

        Create.Table("comments")
            .WithColumn("id").AsInt64().PrimaryKey()
            .WithColumn("hookah_id").AsInt64().ForeignKey()
            .WithColumn("content").AsString()
            .WithColumn("rate").AsInt64();
    }

    public override void Down()
    {
        Delete.Table("hookahs");
        Delete.Table("comments");
    }
}