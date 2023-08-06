using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homework.Data.Migrations
{
    public partial class addingapptabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StageClassifies",
                table: "StageClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecializationClassifies",
                table: "SpecializationClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypeClassifies",
                table: "ServiceTypeClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceStatusClassifies",
                table: "ServiceStatusClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceClassifies",
                table: "ServiceClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReligionClassifies",
                table: "ReligionClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PositionClassifies",
                table: "PositionClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OccupationClassifies",
                table: "OccupationClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalityClassifies",
                table: "NationalityClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalismClassifies",
                table: "NationalismClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaritalStatusClassifies",
                table: "MaritalStatusClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageClassifies",
                table: "LanguageClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitlesClassifies",
                table: "JobTitlesClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobLocationClassifies",
                table: "JobLocationClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobDegreeClassifies",
                table: "JobDegreeClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GovernorateClassifies",
                table: "GovernorateClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeoLocationClassifies",
                table: "GeoLocationClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpStatesClassifies",
                table: "EmpStatesClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentTypeClassifies",
                table: "DocumentTypeClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentSubjectClassifies",
                table: "DocumentSubjectClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CertificateClassifies",
                table: "CertificateClassifies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdministrativeStands",
                table: "AdministrativeStands");

            migrationBuilder.RenameTable(
                name: "StageClassifies",
                newName: "StageTable");

            migrationBuilder.RenameTable(
                name: "SpecializationClassifies",
                newName: "SpecializationTable");

            migrationBuilder.RenameTable(
                name: "ServiceTypeClassifies",
                newName: "ServiceTypeTable");

            migrationBuilder.RenameTable(
                name: "ServiceStatusClassifies",
                newName: "ServiceStatusTable");

            migrationBuilder.RenameTable(
                name: "ServiceClassifies",
                newName: "ServiceTable");

            migrationBuilder.RenameTable(
                name: "ReligionClassifies",
                newName: "ReligionTable");

            migrationBuilder.RenameTable(
                name: "PositionClassifies",
                newName: "PositionTable");

            migrationBuilder.RenameTable(
                name: "OccupationClassifies",
                newName: "OccupationTable");

            migrationBuilder.RenameTable(
                name: "NationalityClassifies",
                newName: "NationalityTable");

            migrationBuilder.RenameTable(
                name: "NationalismClassifies",
                newName: "NationalismTable");

            migrationBuilder.RenameTable(
                name: "MaritalStatusClassifies",
                newName: "MaritalStatusTable");

            migrationBuilder.RenameTable(
                name: "LanguageClassifies",
                newName: "LanguageTable");

            migrationBuilder.RenameTable(
                name: "JobTitlesClassifies",
                newName: "JobTitlesTable");

            migrationBuilder.RenameTable(
                name: "JobLocationClassifies",
                newName: "JobLocationTable");

            migrationBuilder.RenameTable(
                name: "JobDegreeClassifies",
                newName: "JobDegreeTable");

            migrationBuilder.RenameTable(
                name: "GovernorateClassifies",
                newName: "GovernoraTable");

            migrationBuilder.RenameTable(
                name: "GeoLocationClassifies",
                newName: "GeoLocationTable");

            migrationBuilder.RenameTable(
                name: "EmpStatesClassifies",
                newName: "EmpStatesTable");

            migrationBuilder.RenameTable(
                name: "DocumentTypeClassifies",
                newName: "DocumentTypeTable");

            migrationBuilder.RenameTable(
                name: "DocumentSubjectClassifies",
                newName: "DocumentSubjectTable");

            migrationBuilder.RenameTable(
                name: "CertificateClassifies",
                newName: "Certificatetabel");

            migrationBuilder.RenameTable(
                name: "AdministrativeStands",
                newName: "AdministrativeTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stagetabel",
                table: "StageTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specializationtabel",
                table: "SpecializationTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypetabel",
                table: "ServiceTypeTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceStatustabel",
                table: "ServiceStatusTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servicetabel",
                table: "ServiceTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Religiontabel",
                table: "ReligionTable",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positiontabel",
                table: "PositionTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupationtabel",
                table: "OccupationTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nationalitytabel",
                table: "NationalityTable",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nationalismtabel",
                table: "NationalismTable",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaritalStatustabel",
                table: "MaritalStatusTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languagetabel",
                table: "LanguageTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitlestabel",
                table: "JobTitlesTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobLocationtabel",
                table: "JobLocationTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobDegreetabel",
                table: "JobDegreeTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Governoratetabel",
                table: "GovernoraTable",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeoLocationtabel",
                table: "GeoLocationTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpStatestabel",
                table: "EmpStatesTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentTypetabel",
                table: "DocumentTypeTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentSubjecttabel",
                table: "DocumentSubjectTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificatetabel",
                table: "Certificatetabel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administrativetabel",
                table: "AdministrativeTable",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stagetabel",
                table: "StageTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specializationtabel",
                table: "SpecializationTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypetabel",
                table: "ServiceTypeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servicetabel",
                table: "ServiceTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceStatustabel",
                table: "ServiceStatusTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Religiontabel",
                table: "ReligionTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positiontabel",
                table: "PositionTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occupationtabel",
                table: "OccupationTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nationalitytabel",
                table: "NationalityTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nationalismtabel",
                table: "NationalismTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaritalStatustabel",
                table: "MaritalStatusTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languagetabel",
                table: "LanguageTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitlestabel",
                table: "JobTitlesTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobLocationtabel",
                table: "JobLocationTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobDegreetabel",
                table: "JobDegreeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Governoratetabel",
                table: "GovernoraTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeoLocationtabel",
                table: "GeoLocationTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpStatestabel",
                table: "EmpStatesTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentTypetabel",
                table: "DocumentTypeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentSubjecttabel",
                table: "DocumentSubjectTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificatetabel",
                table: "Certificatetabel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administrativetabel",
                table: "AdministrativeTable");

            migrationBuilder.RenameTable(
                name: "StageTable",
                newName: "StageClassifies");

            migrationBuilder.RenameTable(
                name: "SpecializationTable",
                newName: "SpecializationClassifies");

            migrationBuilder.RenameTable(
                name: "ServiceTypeTable",
                newName: "ServiceTypeClassifies");

            migrationBuilder.RenameTable(
                name: "ServiceTable",
                newName: "ServiceClassifies");

            migrationBuilder.RenameTable(
                name: "ServiceStatusTable",
                newName: "ServiceStatusClassifies");

            migrationBuilder.RenameTable(
                name: "ReligionTable",
                newName: "ReligionClassifies");

            migrationBuilder.RenameTable(
                name: "PositionTable",
                newName: "PositionClassifies");

            migrationBuilder.RenameTable(
                name: "OccupationTable",
                newName: "OccupationClassifies");

            migrationBuilder.RenameTable(
                name: "NationalityTable",
                newName: "NationalityClassifies");

            migrationBuilder.RenameTable(
                name: "NationalismTable",
                newName: "NationalismClassifies");

            migrationBuilder.RenameTable(
                name: "MaritalStatusTable",
                newName: "MaritalStatusClassifies");

            migrationBuilder.RenameTable(
                name: "LanguageTable",
                newName: "LanguageClassifies");

            migrationBuilder.RenameTable(
                name: "JobTitlesTable",
                newName: "JobTitlesClassifies");

            migrationBuilder.RenameTable(
                name: "JobLocationTable",
                newName: "JobLocationClassifies");

            migrationBuilder.RenameTable(
                name: "JobDegreeTable",
                newName: "JobDegreeClassifies");

            migrationBuilder.RenameTable(
                name: "GovernoraTable",
                newName: "GovernorateClassifies");

            migrationBuilder.RenameTable(
                name: "GeoLocationTable",
                newName: "GeoLocationClassifies");

            migrationBuilder.RenameTable(
                name: "EmpStatesTable",
                newName: "EmpStatesClassifies");

            migrationBuilder.RenameTable(
                name: "DocumentTypeTable",
                newName: "DocumentTypeClassifies");

            migrationBuilder.RenameTable(
                name: "DocumentSubjectTable",
                newName: "DocumentSubjectClassifies");

            migrationBuilder.RenameTable(
                name: "Certificatetabel",
                newName: "CertificateClassifies");

            migrationBuilder.RenameTable(
                name: "AdministrativeTable",
                newName: "AdministrativeStands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StageClassifies",
                table: "StageClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecializationClassifies",
                table: "SpecializationClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypeClassifies",
                table: "ServiceTypeClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceClassifies",
                table: "ServiceClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceStatusClassifies",
                table: "ServiceStatusClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReligionClassifies",
                table: "ReligionClassifies",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PositionClassifies",
                table: "PositionClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OccupationClassifies",
                table: "OccupationClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalityClassifies",
                table: "NationalityClassifies",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalismClassifies",
                table: "NationalismClassifies",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaritalStatusClassifies",
                table: "MaritalStatusClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageClassifies",
                table: "LanguageClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitlesClassifies",
                table: "JobTitlesClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobLocationClassifies",
                table: "JobLocationClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobDegreeClassifies",
                table: "JobDegreeClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GovernorateClassifies",
                table: "GovernorateClassifies",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeoLocationClassifies",
                table: "GeoLocationClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpStatesClassifies",
                table: "EmpStatesClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentTypeClassifies",
                table: "DocumentTypeClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentSubjectClassifies",
                table: "DocumentSubjectClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CertificateClassifies",
                table: "CertificateClassifies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdministrativeStands",
                table: "AdministrativeStands",
                column: "Id");
        }
    }
}
