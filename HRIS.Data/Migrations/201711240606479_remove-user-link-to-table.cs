namespace HRIS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeuserlinktotable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ta_CutOffAttendance", "sys_User_changeStatusBy_id", "dbo.sys_User");
            DropForeignKey("dbo.ta_CutOffAttendance", "sys_User_updatedBy_id", "dbo.sys_User");
            DropForeignKey("dbo.ta_ApplicationRequestApprover", "sys_User_approverId_id", "dbo.sys_User");
            DropForeignKey("dbo.ta_ApplicationRequestApprover", "sys_User_updatedBy_id", "dbo.sys_User");
            DropIndex("dbo.ta_CutOffAttendance", new[] { "sys_User_changeStatusBy_id" });
            DropIndex("dbo.ta_CutOffAttendance", new[] { "sys_User_updatedBy_id" });
            DropIndex("dbo.ta_ApplicationRequestApprover", new[] { "sys_User_approverId_id" });
            DropIndex("dbo.ta_ApplicationRequestApprover", new[] { "sys_User_updatedBy_id" });
            DropColumn("dbo.ta_CutOffAttendance", "sys_User_changeStatusBy_id");
            DropColumn("dbo.ta_CutOffAttendance", "sys_User_updatedBy_id");
            DropColumn("dbo.ta_ApplicationRequestApprover", "sys_User_approverId_id");
            DropColumn("dbo.ta_ApplicationRequestApprover", "sys_User_updatedBy_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ta_ApplicationRequestApprover", "sys_User_updatedBy_id", c => c.Int());
            AddColumn("dbo.ta_ApplicationRequestApprover", "sys_User_approverId_id", c => c.Int());
            AddColumn("dbo.ta_CutOffAttendance", "sys_User_updatedBy_id", c => c.Int());
            AddColumn("dbo.ta_CutOffAttendance", "sys_User_changeStatusBy_id", c => c.Int());
            CreateIndex("dbo.ta_ApplicationRequestApprover", "sys_User_updatedBy_id");
            CreateIndex("dbo.ta_ApplicationRequestApprover", "sys_User_approverId_id");
            CreateIndex("dbo.ta_CutOffAttendance", "sys_User_updatedBy_id");
            CreateIndex("dbo.ta_CutOffAttendance", "sys_User_changeStatusBy_id");
            AddForeignKey("dbo.ta_ApplicationRequestApprover", "sys_User_updatedBy_id", "dbo.sys_User", "id");
            AddForeignKey("dbo.ta_ApplicationRequestApprover", "sys_User_approverId_id", "dbo.sys_User", "id");
            AddForeignKey("dbo.ta_CutOffAttendance", "sys_User_updatedBy_id", "dbo.sys_User", "id");
            AddForeignKey("dbo.ta_CutOffAttendance", "sys_User_changeStatusBy_id", "dbo.sys_User", "id");
        }
    }
}
