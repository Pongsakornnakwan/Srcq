using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RichnessSoft.Entity.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    addresstype = table.Column<int>(type: "integer", nullable: false),
                    reftype = table.Column<int>(type: "integer", nullable: false),
                    refid = table.Column<string>(type: "varchar(50)", nullable: true),
                    taxpayer = table.Column<string>(type: "varchar(25)", nullable: true),
                    taxrepprefix = table.Column<string>(type: "varchar(50)", nullable: true),
                    taxrepfirstname = table.Column<string>(type: "varchar(100)", nullable: true),
                    taxrepmidname = table.Column<string>(type: "varchar(100)", nullable: true),
                    taxreplastname = table.Column<string>(type: "varchar(100)", nullable: true),
                    taxrepfirstname2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    taxrepmidname2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    taxreplastname2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    taxrepname = table.Column<string>(type: "varchar(255)", nullable: true),
                    taxrepname2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    taxrepsname = table.Column<string>(type: "varchar(255)", nullable: true),
                    taxtepsname2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    taxreptaxid = table.Column<string>(type: "varchar(25)", nullable: true),
                    taxrepbranchno = table.Column<string>(type: "varchar(25)", nullable: true),
                    taxrepbranchname = table.Column<string>(type: "varchar(255)", nullable: true),
                    no = table.Column<string>(type: "varchar(10)", nullable: true),
                    moo = table.Column<string>(type: "varchar(10)", nullable: true),
                    floor = table.Column<string>(type: "varchar(10)", nullable: true),
                    room = table.Column<string>(type: "varchar(10)", nullable: true),
                    village = table.Column<string>(type: "varchar(255)", nullable: true),
                    village2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    building = table.Column<string>(type: "varchar(255)", nullable: true),
                    building2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    soi = table.Column<string>(type: "varchar(255)", nullable: true),
                    soi2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    yaek = table.Column<string>(type: "varchar(10)", nullable: true),
                    road = table.Column<string>(type: "varchar(255)", nullable: true),
                    road2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    tambolcode = table.Column<string>(type: "varchar(25)", nullable: true),
                    tambolname = table.Column<string>(type: "varchar(255)", nullable: true),
                    tambolname2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    amplurcode = table.Column<string>(type: "varchar(25)", nullable: true),
                    amplurname = table.Column<string>(type: "varchar(255)", nullable: true),
                    amplurname2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    provincecode = table.Column<string>(type: "varchar(25)", nullable: true),
                    provincename = table.Column<string>(type: "varchar(255)", nullable: true),
                    provincename2 = table.Column<string>(type: "varchar(25)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(25)", nullable: true),
                    countryname = table.Column<string>(type: "varchar(255)", nullable: true),
                    countryname2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    cipcode = table.Column<string>(type: "varchar(10)", nullable: true),
                    zipcode = table.Column<string>(type: "text", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(25)", nullable: false),
                    taxid = table.Column<string>(type: "varchar(50)", nullable: true),
                    name1 = table.Column<string>(type: "varchar(255)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    houseno = table.Column<string>(type: "varchar(50)", nullable: true),
                    moo = table.Column<string>(type: "varchar(50)", nullable: true),
                    floor = table.Column<string>(type: "varchar(50)", nullable: true),
                    room = table.Column<string>(type: "varchar(50)", nullable: true),
                    village = table.Column<string>(type: "varchar(100)", nullable: true),
                    village2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    building = table.Column<string>(type: "varchar(100)", nullable: true),
                    building2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    lane = table.Column<string>(type: "varchar(100)", nullable: true),
                    lane2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    yaek = table.Column<string>(type: "varchar(10)", nullable: true),
                    road = table.Column<string>(type: "varchar(10)", nullable: true),
                    road2 = table.Column<string>(type: "varchar(10)", nullable: true),
                    subdisrictid = table.Column<string>(type: "varchar(10)", nullable: false),
                    disrictid = table.Column<string>(type: "varchar(10)", nullable: false),
                    provinceid = table.Column<string>(type: "varchar(10)", nullable: false),
                    countryid = table.Column<string>(type: "varchar(10)", nullable: false),
                    postalid = table.Column<string>(type: "varchar(10)", nullable: false),
                    tel2 = table.Column<string>(type: "varchar(10)", nullable: true),
                    tel = table.Column<string>(type: "varchar(10)", nullable: true),
                    fax = table.Column<string>(type: "varchar(10)", nullable: true),
                    website = table.Column<string>(type: "varchar(10)", nullable: true),
                    onwername = table.Column<string>(type: "varchar(10)", nullable: true),
                    registerno = table.Column<string>(type: "varchar(10)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "doctype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    system = table.Column<string>(type: "varchar(10)", nullable: true),
                    menu = table.Column<string>(type: "varchar(50)", nullable: true),
                    type = table.Column<string>(type: "varchar(100)", nullable: true),
                    doc_group = table.Column<string>(type: "varchar(2)", nullable: true),
                    code = table.Column<string>(type: "varchar(10)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(500)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(500)", nullable: true),
                    vat = table.Column<string>(type: "varchar(10)", nullable: true),
                    cash = table.Column<string>(type: "varchar(10)", nullable: true),
                    service = table.Column<string>(type: "varchar(10)", nullable: true),
                    tax_refund = table.Column<string>(type: "varchar(10)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "erp_log",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    logdatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    logtype = table.Column<string>(type: "text", nullable: true),
                    doc_no = table.Column<string>(type: "text", nullable: true),
                    old_doc_no = table.Column<string>(type: "text", nullable: true),
                    doc_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    old_doc_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_code = table.Column<string>(type: "text", nullable: true),
                    data_new = table.Column<string>(type: "text", nullable: true),
                    data_old = table.Column<string>(type: "text", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_erp_log", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    logid = table.Column<int>(type: "integer", nullable: false),
                    message = table.Column<string>(type: "text", nullable: true),
                    exception = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    thread = table.Column<string>(type: "text", nullable: true),
                    level = table.Column<string>(type: "text", nullable: true),
                    logger = table.Column<string>(type: "text", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    desc1 = table.Column<string>(type: "text", nullable: true),
                    desc2 = table.Column<string>(type: "text", nullable: true),
                    parrentmenu = table.Column<string>(type: "varchar(50)", nullable: true),
                    path = table.Column<string>(type: "varchar(1000)", nullable: true),
                    module = table.Column<string>(type: "varchar(50)", nullable: true),
                    menutype = table.Column<string>(type: "varchar(50)", nullable: true),
                    icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    command = table.Column<string>(type: "varchar(255)", nullable: true),
                    color = table.Column<string>(type: "varchar(100)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "paytype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    isdeposit = table.Column<string>(type: "varchar(150)", nullable: true),
                    iswithdraw = table.Column<string>(type: "varchar(150)", nullable: true),
                    group = table.Column<string>(type: "varchar(150)", nullable: true),
                    inout = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paytype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "postalcountry",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    code2 = table.Column<string>(type: "text", nullable: true),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postalcountry", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "postaldisrict",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(10)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    provincecode = table.Column<string>(type: "varchar(250)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(250)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postaldisrict", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "postalprovince",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(10)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(250)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postalprovince", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "postalsubdisrict",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(10)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    disrictcode = table.Column<string>(type: "varchar(250)", nullable: true),
                    provincecode = table.Column<string>(type: "varchar(250)", nullable: true),
                    countrycode = table.Column<string>(type: "varchar(250)", nullable: true),
                    postal_code = table.Column<string>(type: "varchar(5)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postalsubdisrict", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "prodtype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    flag = table.Column<string>(type: "varchar(150)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prodtype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "productshelf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    warehouseid = table.Column<int>(type: "integer", nullable: false),
                    shelfid = table.Column<int>(type: "integer", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    width = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    length = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    height = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productshelf", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name1 = table.Column<string>(type: "text", nullable: true),
                    name2 = table.Column<string>(type: "text", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rolemenu",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rolecode = table.Column<string>(type: "varchar(50)", nullable: false),
                    menucode = table.Column<string>(type: "varchar(50)", nullable: false),
                    canopen = table.Column<bool>(type: "boolean", nullable: false),
                    canadd = table.Column<bool>(type: "boolean", nullable: false),
                    canedit = table.Column<bool>(type: "boolean", nullable: false),
                    candelete = table.Column<bool>(type: "boolean", nullable: false),
                    canprint = table.Column<bool>(type: "boolean", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolemenu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rolecode = table.Column<int>(type: "integer", nullable: false),
                    usercode = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "storageimage",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sourceimage = table.Column<string>(type: "varchar(100)", nullable: true),
                    refdocid = table.Column<string>(type: "varchar(25)", nullable: true),
                    source = table.Column<string>(type: "varchar(255)", nullable: true),
                    alt = table.Column<string>(type: "varchar(255)", nullable: true),
                    caption = table.Column<string>(type: "varchar(255)", nullable: true),
                    header = table.Column<string>(type: "varchar(255)", nullable: true),
                    seq = table.Column<string>(type: "varchar(4)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storageimage", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sysoption",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    startaccountdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    endaccountdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    carryingamountdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    startsystemdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    postaccount = table.Column<string>(type: "varchar(1)", nullable: true),
                    vattype = table.Column<string>(type: "varchar(1)", nullable: true),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: true),
                    taxapproveno = table.Column<string>(type: "varchar(100)", nullable: true),
                    taxapprovedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    taxpayname = table.Column<string>(type: "varchar(200)", nullable: true),
                    taxpayposition = table.Column<string>(type: "varchar(200)", nullable: true),
                    inputitemqty = table.Column<int>(type: "integer", nullable: false),
                    inputitemqtydecimal = table.Column<int>(type: "integer", nullable: false),
                    inputprice = table.Column<int>(type: "integer", nullable: false),
                    inputpricedecimal = table.Column<int>(type: "integer", nullable: false),
                    inputitemamt = table.Column<int>(type: "integer", nullable: false),
                    inputitemamtdecimal = table.Column<int>(type: "integer", nullable: false),
                    inputvat = table.Column<int>(type: "integer", nullable: false),
                    inputvatdecimal = table.Column<int>(type: "integer", nullable: false),
                    reportitemqty = table.Column<int>(type: "integer", nullable: false),
                    reportitemqtydecimal = table.Column<int>(type: "integer", nullable: false),
                    reportprice = table.Column<int>(type: "integer", nullable: false),
                    reportpricedecimal = table.Column<int>(type: "integer", nullable: false),
                    reportitemamt = table.Column<int>(type: "integer", nullable: false),
                    reportitemamtdecimal = table.Column<int>(type: "integer", nullable: false),
                    reportvat = table.Column<int>(type: "integer", nullable: false),
                    reportvatdecimal = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: false),
                    projectid = table.Column<int>(type: "integer", nullable: false),
                    buywarehouseid = table.Column<int>(type: "integer", nullable: false),
                    salewarehouseid = table.Column<int>(type: "integer", nullable: false),
                    revalueaccountbookid = table.Column<int>(type: "integer", nullable: false),
                    assetaccountbookid = table.Column<int>(type: "integer", nullable: false),
                    insuranaccountbookid = table.Column<int>(type: "integer", nullable: false),
                    stockcounting = table.Column<string>(type: "varchar(1)", nullable: true),
                    controllot = table.Column<string>(type: "varchar(10)", nullable: true),
                    controlserial = table.Column<string>(type: "varchar(10)", nullable: true),
                    fgcost = table.Column<string>(type: "varchar(1)", nullable: true),
                    rmcost = table.Column<string>(type: "varchar(1)", nullable: true),
                    cscost = table.Column<string>(type: "varchar(1)", nullable: true),
                    fgglpost = table.Column<string>(type: "varchar(2)", nullable: true),
                    rmglpost = table.Column<string>(type: "varchar(2)", nullable: true),
                    csglpost = table.Column<string>(type: "varchar(2)", nullable: true),
                    selectbuyprice = table.Column<string>(type: "varchar(30)", nullable: true),
                    selectsaleprice = table.Column<string>(type: "varchar(30)", nullable: true),
                    costcnbuy = table.Column<string>(type: "varchar(10)", nullable: true),
                    costcnsale = table.Column<string>(type: "varchar(10)", nullable: true),
                    costproductzero = table.Column<string>(type: "varchar(10)", nullable: true),
                    costcountstockdoc = table.Column<string>(type: "varchar(10)", nullable: true),
                    costreturnwithdraw = table.Column<string>(type: "varchar(10)", nullable: true),
                    glyearmode = table.Column<string>(type: "varchar(10)", nullable: true),
                    glformatdoc = table.Column<string>(type: "varchar(10)", nullable: true),
                    glrundoclen = table.Column<int>(type: "integer", nullable: false),
                    glheadmessage = table.Column<string>(type: "varchar(100)", nullable: true),
                    docyearmode = table.Column<string>(type: "varchar(10)", nullable: true),
                    docformatdoc = table.Column<string>(type: "varchar(10)", nullable: true),
                    docrundoclen = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sysoption", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "varchar(50)", nullable: true),
                    password = table.Column<string>(type: "varchar(150)", nullable: true),
                    firstname = table.Column<string>(type: "varchar(150)", nullable: true),
                    lastname = table.Column<string>(type: "varchar(150)", nullable: true),
                    email = table.Column<string>(type: "varchar(150)", nullable: true),
                    token = table.Column<string>(type: "varchar(1000)", nullable: true),
                    confirmpassword = table.Column<string>(type: "varchar(150)", nullable: true),
                    usertype = table.Column<string>(type: "varchar(150)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vattype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    rate = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    vat_type = table.Column<int>(type: "integer", nullable: false),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vattype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "warehousetype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehousetype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "accbook",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(25)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(255)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accbook", x => x.id);
                    table.ForeignKey(
                        name: "FK_accbook_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "acchart",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(25)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(255)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    tag = table.Column<string>(type: "varchar(50)", nullable: true),
                    tag2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    level = table.Column<int>(type: "integer", nullable: false),
                    isfixed = table.Column<int>(type: "integer", nullable: false),
                    group = table.Column<string>(type: "varchar(1)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true),
                    inactivedate = table.Column<DateTime>(type: "date", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acchart", x => x.id);
                    table.ForeignKey(
                        name: "FK_acchart_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "accrole",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(25)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(255)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    description = table.Column<string>(type: "varchar(100)", nullable: true),
                    sysvariable = table.Column<string>(type: "varchar(100)", nullable: true),
                    acchartid = table.Column<int>(type: "integer", nullable: true),
                    acchart_code = table.Column<string>(type: "text", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accrole", x => x.id);
                    table.ForeignKey(
                        name: "FK_accrole_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "accroletemplateh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(25)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    description = table.Column<string>(type: "varchar(100)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accroletemplateh", x => x.id);
                    table.ForeignKey(
                        name: "FK_accroletemplateh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bank",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    botcode = table.Column<string>(type: "text", nullable: true),
                    swicfcode = table.Column<string>(type: "text", nullable: true),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bank", x => x.id);
                    table.ForeignKey(
                        name: "FK_bank_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "branch",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    addr1 = table.Column<string>(type: "text", nullable: true),
                    addr2 = table.Column<string>(type: "text", nullable: true),
                    tel = table.Column<string>(type: "text", nullable: true),
                    fax = table.Column<string>(type: "text", nullable: true),
                    is_headbrn = table.Column<string>(type: "text", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch", x => x.id);
                    table.ForeignKey(
                        name: "FK_branch_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand", x => x.id);
                    table.ForeignKey(
                        name: "FK_brand_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                    table.ForeignKey(
                        name: "FK_category_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.id);
                    table.ForeignKey(
                        name: "FK_color_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    contacttype = table.Column<int>(type: "integer", nullable: false),
                    reftype = table.Column<int>(type: "integer", nullable: false),
                    refid = table.Column<string>(type: "text", nullable: true),
                    contactname = table.Column<string>(type: "varchar(50)", nullable: false),
                    positionname = table.Column<string>(type: "varchar(150)", nullable: false),
                    remark = table.Column<string>(type: "varchar(150)", nullable: true),
                    mobile = table.Column<string>(type: "varchar(150)", nullable: true),
                    tel = table.Column<string>(type: "varchar(150)", nullable: true),
                    companyname = table.Column<string>(type: "varchar(150)", nullable: true),
                    seq = table.Column<string>(type: "varchar(50)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.id);
                    table.ForeignKey(
                        name: "FK_contact_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "currency",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    ratio = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m),
                    symbol = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: ""),
                    countrycode = table.Column<string>(type: "text", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currency", x => x.id);
                    table.ForeignKey(
                        name: "FK_currency_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customecredit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    customerid = table.Column<int>(type: "integer", nullable: false),
                    CreditType = table.Column<string>(type: "varchar(50)", nullable: false, comment: "ประเภทเครดิต I = วงเงินเครดิตเพิ่ม , R = วงเงินเครดิตลด"),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวนเงิน"),
                    enddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    reftype = table.Column<string>(type: "varchar(1)", nullable: true),
                    seq = table.Column<string>(type: "varchar(1)", nullable: false, comment: "`ลำดับ"),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customecredit", x => x.id);
                    table.ForeignKey(
                        name: "FK_customecredit_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "description",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    desc = table.Column<string>(type: "varchar(500)", nullable: false),
                    desc2 = table.Column<string>(type: "varchar(500)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    dtype = table.Column<string>(type: "varchar(4)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_description", x => x.id);
                    table.ForeignKey(
                        name: "FK_description_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "design",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_design", x => x.id);
                    table.ForeignKey(
                        name: "FK_design_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "format",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_format", x => x.id);
                    table.ForeignKey(
                        name: "FK_format_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "formmaster",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    Active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formmaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_formmaster_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "fromref",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    reffromtable = table.Column<string>(type: "varchar(50)", nullable: true),
                    reffromcode = table.Column<string>(type: "varchar(50)", nullable: true),
                    formtype = table.Column<string>(type: "varchar(50)", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fromref", x => x.id);
                    table.ForeignKey(
                        name: "FK_fromref_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "grade",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grade", x => x.id);
                    table.ForeignKey(
                        name: "FK_grade_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "membergroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membergroup", x => x.id);
                    table.ForeignKey(
                        name: "FK_membergroup_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "model",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_model", x => x.id);
                    table.ForeignKey(
                        name: "FK_model_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mop",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mop", x => x.id);
                    table.ForeignKey(
                        name: "FK_mop_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "plans",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plans", x => x.id);
                    table.ForeignKey(
                        name: "FK_plans_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.id);
                    table.ForeignKey(
                        name: "FK_positions_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productgroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    accbuycashid = table.Column<int>(type: "integer", nullable: true),
                    accbuycreditid = table.Column<int>(type: "integer", nullable: true),
                    accsalecashid = table.Column<int>(type: "integer", nullable: true),
                    accsalecreditid = table.Column<int>(type: "integer", nullable: true),
                    acccostid = table.Column<int>(type: "integer", nullable: true),
                    accstockid = table.Column<int>(type: "integer", nullable: true),
                    AccWorkInProcessId = table.Column<int>(type: "integer", nullable: true),
                    accsuppliedusedid = table.Column<int>(type: "integer", nullable: true),
                    accmaterialrequistionid = table.Column<int>(type: "integer", nullable: true),
                    budgetgroupid = table.Column<int>(type: "integer", nullable: true),
                    acccngoodid = table.Column<int>(type: "integer", nullable: true),
                    acccnpriceid = table.Column<int>(type: "integer", nullable: true),
                    accincreasedebtreturnincreaseid = table.Column<int>(type: "integer", nullable: true),
                    accincreasedebtpriceincreaseid = table.Column<int>(type: "integer", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productgroup", x => x.id);
                    table.ForeignKey(
                        name: "FK_productgroup_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productset",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(30)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    sname1 = table.Column<string>(type: "varchar(250)", nullable: true),
                    sname2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    prodtype = table.Column<string>(type: "varchar(25)", nullable: true),
                    setprint = table.Column<string>(type: "varchar(1)", nullable: true),
                    vattype = table.Column<string>(type: "varchar(10)", nullable: true),
                    remark = table.Column<string>(type: "varchar(500)", nullable: true),
                    remark2 = table.Column<string>(type: "varchar(500)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productset", x => x.id);
                    table.ForeignKey(
                        name: "FK_productset_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    planid = table.Column<int>(type: "integer", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.id);
                    table.ForeignKey(
                        name: "FK_project_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "salearea",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salearea", x => x.id);
                    table.ForeignKey(
                        name: "FK_salearea_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "saleman",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    card_no = table.Column<string>(type: "varchar(25)", nullable: true),
                    prefix_th = table.Column<string>(type: "varchar(30)", nullable: true),
                    prefix_en = table.Column<string>(type: "varchar(30)", nullable: true),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    tel = table.Column<string>(type: "varchar(20)", nullable: true),
                    mobile = table.Column<string>(type: "varchar(20)", nullable: true),
                    line = table.Column<string>(type: "varchar(100)", nullable: true),
                    email = table.Column<string>(type: "varchar(100)", nullable: true),
                    position = table.Column<string>(type: "varchar(50)", nullable: true),
                    login = table.Column<string>(type: "varchar(100)", nullable: true),
                    sale_team = table.Column<string>(type: "varchar(50)", nullable: true),
                    sale_area = table.Column<string>(type: "varchar(50)", nullable: true),
                    commission = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    signature = table.Column<string>(type: "varchar(1000)", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleman", x => x.id);
                    table.ForeignKey(
                        name: "FK_saleman_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "saleteam",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleteam", x => x.id);
                    table.ForeignKey(
                        name: "FK_saleteam_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "section",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_section", x => x.id);
                    table.ForeignKey(
                        name: "FK_section_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "segmentation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_segmentation", x => x.id);
                    table.ForeignKey(
                        name: "FK_segmentation_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "shipping",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shipping", x => x.id);
                    table.ForeignKey(
                        name: "FK_shipping_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_size", x => x.id);
                    table.ForeignKey(
                        name: "FK_size_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "um",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_um", x => x.id);
                    table.ForeignKey(
                        name: "FK_um_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vendorgroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    acchartid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(250)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(250)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendorgroup", x => x.id);
                    table.ForeignKey(
                        name: "FK_vendorgroup_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "weight",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(252)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weight", x => x.id);
                    table.ForeignKey(
                        name: "FK_weight_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "assetgroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    acchartid = table.Column<int>(type: "integer", nullable: true),
                    Depreciateacchartid = table.Column<int>(type: "integer", nullable: true),
                    DepreciateSumacchartid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assetgroup", x => x.id);
                    table.ForeignKey(
                        name: "FK_assetgroup_acchart_acchartid",
                        column: x => x.acchartid,
                        principalTable: "acchart",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetgroup_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "custgroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    acchartid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    levelprice = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custgroup", x => x.id);
                    table.ForeignKey(
                        name: "FK_custgroup_acchart_acchartid",
                        column: x => x.acchartid,
                        principalTable: "acchart",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_custgroup_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "accroletemplated",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    acchartid = table.Column<int>(type: "integer", nullable: true),
                    accroletemplatehid = table.Column<int>(type: "integer", nullable: true),
                    accrolecode = table.Column<string>(type: "varchar(25)", nullable: false),
                    accroledesc = table.Column<string>(type: "varchar(150)", nullable: false),
                    accroledesc2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accroletemplated", x => x.id);
                    table.ForeignKey(
                        name: "FK_accroletemplated_acchart_acchartid",
                        column: x => x.acchartid,
                        principalTable: "acchart",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_accroletemplated_accroletemplateh_accroletemplatehid",
                        column: x => x.accroletemplatehid,
                        principalTable: "accroletemplateh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bankbranch",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    bankid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bankbranch", x => x.id);
                    table.ForeignKey(
                        name: "FK_bankbranch_bank_bankid",
                        column: x => x.bankid,
                        principalTable: "bank",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bankbranch_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bilpay",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<string>(type: "varchar(25)", nullable: true),
                    masterid = table.Column<string>(type: "varchar(25)", nullable: true),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    paymentid = table.Column<string>(type: "varchar(25)", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    status = table.Column<string>(type: "varchar(4)", nullable: true),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bilpay", x => x.id);
                    table.ForeignKey(
                        name: "FK_bilpay_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bilpay_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: true),
                    branchid = table.Column<int>(type: "integer", nullable: true),
                    accbookid = table.Column<int>(type: "integer", nullable: true),
                    accroletemplatehid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "text", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    prefixrunno = table.Column<string>(type: "varchar(20)", nullable: true, defaultValue: "", comment: "ขึ้นต้น"),
                    yearrunno = table.Column<string>(type: "varchar(20)", nullable: true, defaultValue: "", comment: "รูปแบบปี "),
                    docformatrunno = table.Column<string>(type: "varchar(20)", nullable: true, defaultValue: "", comment: "รูปแบบการ Running เอกสาร"),
                    doclenrunno = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "จำนวนหลักในการ Running"),
                    docstartrunno = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "เลขที่เริ่มต้น"),
                    lockdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Lock ข้อมูลห้ามแก้ไข ถึงวันที่"),
                    accremarkdetail = table.Column<string>(type: "text", nullable: true, comment: "หมายเหตุการลงลัญชี"),
                    warehouseid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: false),
                    vattype = table.Column<string>(type: "varchar(20)", nullable: true, defaultValue: "", comment: "ประเภทภาษี "),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.id);
                    table.ForeignKey(
                        name: "FK_book_accbook_accbookid",
                        column: x => x.accbookid,
                        principalTable: "accbook",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_book_accroletemplateh_accroletemplatehid",
                        column: x => x.accroletemplatehid,
                        principalTable: "accroletemplateh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_book_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_book_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "warehouse",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    warehousetype = table.Column<string>(type: "varchar(25)", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouse", x => x.id);
                    table.ForeignKey(
                        name: "FK_warehouse_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_warehouse_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true, comment: "ฝ่ายงาน"),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.id);
                    table.ForeignKey(
                        name: "FK_department_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_department_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vendor",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    vendorgroupid = table.Column<int>(type: "integer", nullable: true),
                    accreceivableid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(30)", nullable: false),
                    vendortype = table.Column<string>(type: "varchar(1)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    prename = table.Column<string>(type: "varchar(30)", nullable: true),
                    firstname = table.Column<string>(type: "varchar(100)", nullable: true),
                    midname = table.Column<string>(type: "varchar(100)", nullable: true),
                    lastname = table.Column<string>(type: "varchar(100)", nullable: true),
                    firstname2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    midname2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    lastname2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    name1 = table.Column<string>(type: "varchar(255)", nullable: true),
                    sname1 = table.Column<string>(type: "varchar(255)", nullable: true),
                    name2 = table.Column<string>(type: "text", nullable: true),
                    sname2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    taxid = table.Column<string>(type: "varchar(25)", nullable: true),
                    cid = table.Column<string>(type: "varchar(25)", nullable: true),
                    headoffice = table.Column<string>(type: "varchar(1)", nullable: true),
                    branchcode = table.Column<string>(type: "varchar(5)", nullable: true),
                    branchname = table.Column<string>(type: "varchar(255)", nullable: true),
                    teletax = table.Column<string>(type: "varchar(50)", nullable: true),
                    tel = table.Column<string>(type: "varchar(50)", nullable: true),
                    fax = table.Column<string>(type: "varchar(50)", nullable: true),
                    website = table.Column<string>(type: "varchar(255)", nullable: true),
                    singlelineaddress = table.Column<string>(type: "varchar(4000)", nullable: true),
                    singlelineaddress2 = table.Column<string>(type: "varchar(4000)", nullable: true),
                    shippingby = table.Column<string>(type: "varchar(25)", nullable: true),
                    bussinesstype = table.Column<string>(type: "varchar(255)", nullable: true),
                    creditdays = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    creditamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    methodofpaymentcode = table.Column<string>(type: "varchar(50)", nullable: true),
                    bookbankno = table.Column<string>(type: "varchar(15)", nullable: true),
                    bookbankname = table.Column<string>(type: "varchar(100)", nullable: true),
                    bankcode = table.Column<string>(type: "varchar(50)", nullable: true),
                    bankbranch = table.Column<string>(type: "varchar(150)", nullable: true),
                    billingcond = table.Column<string>(type: "varchar(255)", nullable: true),
                    creditdays_billing = table.Column<string>(type: "varchar(100)", nullable: false),
                    receivingdatecond = table.Column<string>(type: "varchar(255)", nullable: true),
                    discountendbill = table.Column<string>(type: "varchar(100)", nullable: true),
                    discountitem = table.Column<string>(type: "varchar(100)", nullable: true),
                    currencycode = table.Column<string>(type: "varchar(50)", nullable: true),
                    promotioncode = table.Column<string>(type: "varchar(50)", nullable: true),
                    vattype = table.Column<string>(type: "varchar(50)", nullable: true),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: true),
                    vatrate = table.Column<decimal>(type: "numeric", nullable: false),
                    remark1 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark2 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark3 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark4 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark5 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark6 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark7 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark8 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark9 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark10 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor", x => x.id);
                    table.ForeignKey(
                        name: "FK_vendor_acchart_accreceivableid",
                        column: x => x.accreceivableid,
                        principalTable: "acchart",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vendor_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vendor_vendorgroup_vendorgroupid",
                        column: x => x.vendorgroupid,
                        principalTable: "vendorgroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    productgroupid = table.Column<int>(type: "integer", nullable: true),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    categoryid = table.Column<int>(type: "integer", nullable: true),
                    brandid = table.Column<int>(type: "integer", nullable: true),
                    formatid = table.Column<int>(type: "integer", nullable: true),
                    designid = table.Column<int>(type: "integer", nullable: true),
                    gradeid = table.Column<int>(type: "integer", nullable: true),
                    modelid = table.Column<int>(type: "integer", nullable: true),
                    sizeid = table.Column<int>(type: "integer", nullable: true),
                    colorid = table.Column<int>(type: "integer", nullable: true),
                    weightid = table.Column<int>(type: "integer", nullable: true),
                    accbuycashid = table.Column<int>(type: "integer", nullable: true),
                    accbuycreditid = table.Column<int>(type: "integer", nullable: true),
                    accsalecashid = table.Column<int>(type: "integer", nullable: true),
                    accsalecreditid = table.Column<int>(type: "integer", nullable: true),
                    acccostid = table.Column<int>(type: "integer", nullable: true),
                    accstockid = table.Column<int>(type: "integer", nullable: true),
                    AccWorkInProcessId = table.Column<int>(type: "integer", nullable: true),
                    accsuppliedusedid = table.Column<int>(type: "integer", nullable: true),
                    accmaterialrequistionid = table.Column<int>(type: "integer", nullable: true),
                    budgetgroupid = table.Column<int>(type: "integer", nullable: true),
                    acccngoodid = table.Column<int>(type: "integer", nullable: true),
                    acccnpriceid = table.Column<int>(type: "integer", nullable: true),
                    accincreasedebtreturnincreaseid = table.Column<int>(type: "integer", nullable: true),
                    accincreasedebtpriceincreaseid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(30)", nullable: false),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    name1 = table.Column<string>(type: "varchar(160)", nullable: false),
                    sname1 = table.Column<string>(type: "varchar(160)", nullable: true),
                    name2 = table.Column<string>(type: "varchar(160)", nullable: true),
                    sname2 = table.Column<string>(type: "varchar(160)", nullable: true),
                    prodtype = table.Column<string>(type: "varchar(25)", nullable: true),
                    taxrate = table.Column<string>(type: "varchar(1)", nullable: true),
                    inputtax = table.Column<string>(type: "varchar(1)", nullable: true),
                    salestax = table.Column<string>(type: "varchar(1)", nullable: true),
                    stockcounting = table.Column<string>(type: "varchar(1)", nullable: true),
                    showinventories = table.Column<string>(type: "varchar(1)", nullable: true),
                    purchaseprice = table.Column<string>(type: "varchar(1)", nullable: true),
                    saleprice = table.Column<string>(type: "varchar(1)", nullable: true),
                    stdcost = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    stdprice = table.Column<decimal>(type: "numeric", nullable: false),
                    minprice = table.Column<decimal>(type: "numeric", nullable: false),
                    remark1 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark2 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark3 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark4 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark5 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark6 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark7 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark8 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark9 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark10 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    vattype = table.Column<string>(type: "varchar(10)", nullable: true),
                    commision = table.Column<string>(type: "varchar(1)", nullable: true),
                    cardfee = table.Column<string>(type: "varchar(1)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_brand_brandid",
                        column: x => x.brandid,
                        principalTable: "brand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_category_categoryid",
                        column: x => x.categoryid,
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_color_colorid",
                        column: x => x.colorid,
                        principalTable: "color",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_design_designid",
                        column: x => x.designid,
                        principalTable: "design",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_format_formatid",
                        column: x => x.formatid,
                        principalTable: "format",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_grade_gradeid",
                        column: x => x.gradeid,
                        principalTable: "grade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_model_modelid",
                        column: x => x.modelid,
                        principalTable: "model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_productgroup_productgroupid",
                        column: x => x.productgroupid,
                        principalTable: "productgroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_size_sizeid",
                        column: x => x.sizeid,
                        principalTable: "size",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_weight_weightid",
                        column: x => x.weightid,
                        principalTable: "weight",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "service",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    productgroupid = table.Column<int>(type: "integer", nullable: true),
                    categoryid = table.Column<int>(type: "integer", nullable: true),
                    brandid = table.Column<int>(type: "integer", nullable: true),
                    formatid = table.Column<int>(type: "integer", nullable: true),
                    designid = table.Column<int>(type: "integer", nullable: true),
                    gradeid = table.Column<int>(type: "integer", nullable: true),
                    modelid = table.Column<int>(type: "integer", nullable: true),
                    sizeid = table.Column<int>(type: "integer", nullable: true),
                    colorid = table.Column<int>(type: "integer", nullable: true),
                    weightid = table.Column<int>(type: "integer", nullable: true),
                    umid = table.Column<int>(type: "integer", nullable: true),
                    accbuycashid = table.Column<int>(type: "integer", nullable: true),
                    accbuycreditid = table.Column<int>(type: "integer", nullable: true),
                    accsalecashid = table.Column<int>(type: "integer", nullable: true),
                    accsalecreditid = table.Column<int>(type: "integer", nullable: true),
                    acccostid = table.Column<int>(type: "integer", nullable: true),
                    accstockid = table.Column<int>(type: "integer", nullable: true),
                    AccWorkInProcessId = table.Column<int>(type: "integer", nullable: true),
                    accsuppliedusedid = table.Column<int>(type: "integer", nullable: true),
                    accmaterialrequistionid = table.Column<int>(type: "integer", nullable: true),
                    budgetgroupid = table.Column<int>(type: "integer", nullable: true),
                    acccngoodid = table.Column<int>(type: "integer", nullable: true),
                    acccnpriceid = table.Column<int>(type: "integer", nullable: true),
                    accincreasedebtreturnincreaseid = table.Column<int>(type: "integer", nullable: true),
                    accincreasedebtpriceincreaseid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(30)", nullable: false),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    name1 = table.Column<string>(type: "varchar(160)", nullable: true),
                    sname = table.Column<string>(type: "varchar(160)", nullable: true),
                    name2 = table.Column<string>(type: "varchar(160)", nullable: true),
                    sname2 = table.Column<string>(type: "varchar(160)", nullable: true),
                    prodtype = table.Column<string>(type: "varchar(25)", nullable: true),
                    taxrate = table.Column<string>(type: "varchar(1)", nullable: true),
                    inputtax = table.Column<string>(type: "varchar(1)", nullable: true),
                    salestax = table.Column<string>(type: "varchar(1)", nullable: true),
                    stockcounting = table.Column<string>(type: "varchar(1)", nullable: true),
                    showinventories = table.Column<string>(type: "varchar(1)", nullable: true),
                    purchaseprice = table.Column<string>(type: "varchar(1)", nullable: true),
                    saleprice = table.Column<string>(type: "varchar(1)", nullable: true),
                    stdcost = table.Column<decimal>(type: "numeric", nullable: false),
                    stdprice = table.Column<decimal>(type: "numeric", nullable: false),
                    minprice = table.Column<decimal>(type: "numeric", nullable: false),
                    remark1 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark2 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark3 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark4 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark5 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark6 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark7 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark8 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark9 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark10 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    vattype = table.Column<string>(type: "varchar(10)", nullable: true),
                    commision = table.Column<string>(type: "varchar(1)", nullable: true),
                    cardfee = table.Column<string>(type: "varchar(1)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service", x => x.id);
                    table.ForeignKey(
                        name: "FK_service_brand_brandid",
                        column: x => x.brandid,
                        principalTable: "brand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_category_categoryid",
                        column: x => x.categoryid,
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_color_colorid",
                        column: x => x.colorid,
                        principalTable: "color",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_design_designid",
                        column: x => x.designid,
                        principalTable: "design",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_format_formatid",
                        column: x => x.formatid,
                        principalTable: "format",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_grade_gradeid",
                        column: x => x.gradeid,
                        principalTable: "grade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_model_modelid",
                        column: x => x.modelid,
                        principalTable: "model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_productgroup_productgroupid",
                        column: x => x.productgroupid,
                        principalTable: "productgroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_size_sizeid",
                        column: x => x.sizeid,
                        principalTable: "size",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_weight_weightid",
                        column: x => x.weightid,
                        principalTable: "weight",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asset",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: true),
                    branchid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    acchartid = table.Column<int>(type: "integer", nullable: true),
                    assetgroupid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    depreciateacchartid = table.Column<int>(type: "integer", nullable: true),
                    depreciatesumacchartid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(25)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(255)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    identity = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "เป็นสินทรัพย์มีตัวตัว"),
                    generate = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "ต้องการคำนวณค่าเสื่อม YES = ต้องการคำนวณ, NO = ไม่ต้องการคำนวณ"),
                    buyprice = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "ราคาซื้อ"),
                    transportexpense = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "ค่าใช้จ่ายในการขนส่ง"),
                    setupexpense = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "ค่าใช้จ่ายในการติดตั้ง"),
                    miscellaneousexpense = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "ค่าใช้จ่ายเบ็ดเตล็ด"),
                    totalprice = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "รวมราคาซื้อหรือได้มา"),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "มูลค่าที่ใช้ในการคำนวณ"),
                    amountdepreciat = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "มูลค่าค่าเสื่อมสะสม"),
                    buydate = table.Column<DateTime>(type: "date", nullable: false, comment: "วันที่ซื้อ"),
                    buyinv = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "เลขที่บิลซื้อ"),
                    buyvoucher = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "Payment Voucher"),
                    startdate = table.Column<DateTime>(type: "date", nullable: false, comment: "วันที่เริ่มคำนวณ"),
                    method = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "S", comment: "วิธีการคำนวณ S = เส้นตรง (Straight line) , D = ลดน้อยถอยลง (DDB)"),
                    voucherrecord = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "บันทึกบัญชีทุกๆ M = เดือน , Y = ปี "),
                    rate = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "% อัตราคาเสื่อม"),
                    rateper = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "0", comment: "อัตราต่อ M = เดือน , Y = ปี "),
                    rate2 = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "% อัตรา ณ วันที่ได้มา"),
                    salvage = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "ค่าซาก"),
                    deduct = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "N", comment: "หัก มูลค่าซาก YES = ต้องการหัก , NO = ไม่ต้องการหัก "),
                    stopdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "วันที่หยุดคำนวณ"),
                    saledate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "วันที่ขายไป"),
                    saleinv = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "เลขที่บิลขาย"),
                    salevoucher = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "Receipt Voucher"),
                    customer = table.Column<string>(type: "varchar(300)", nullable: true, defaultValue: "", comment: "ขายให้"),
                    vendor = table.Column<string>(type: "varchar(300)", nullable: true, defaultValue: "", comment: "ซื้อจาก"),
                    brand = table.Column<string>(type: "varchar(300)", nullable: true, defaultValue: "", comment: "ยี่ห้อ"),
                    series = table.Column<string>(type: "varchar(300)", nullable: true, defaultValue: "", comment: "รุ่น"),
                    serial = table.Column<string>(type: "text", nullable: true),
                    usefullife = table.Column<string>(type: "varchar(20)", nullable: true, defaultValue: "", comment: "อายุการใช้งาน"),
                    warrantyno = table.Column<string>(type: "varchar(100)", nullable: true, defaultValue: "", comment: "หมายเลขประกัน"),
                    insurancecomp = table.Column<string>(type: "varchar(300)", nullable: true, defaultValue: "", comment: "บริษัทประกันภัย"),
                    insuranceno = table.Column<string>(type: "varchar(300)", nullable: true, defaultValue: "", comment: "เลขที่กรมธรรน์"),
                    remark = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "เลขที่กรมธรรน์"),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset", x => x.id);
                    table.ForeignKey(
                        name: "FK_asset_acchart_acchartid",
                        column: x => x.acchartid,
                        principalTable: "acchart",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asset_assetgroup_assetgroupid",
                        column: x => x.assetgroupid,
                        principalTable: "assetgroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asset_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asset_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    custgroupid = table.Column<int>(type: "integer", nullable: true),
                    membergroupid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    saleteamid = table.Column<int>(type: "integer", nullable: true),
                    saleareaid = table.Column<int>(type: "integer", nullable: true),
                    segmentationid = table.Column<int>(type: "integer", nullable: true),
                    bankid = table.Column<int>(type: "integer", nullable: true, comment: "ธนาคาร"),
                    receivableacchartid = table.Column<int>(type: "integer", nullable: true, comment: "รหัสบัญชีลูกหนี้การค้า"),
                    memberpriceid = table.Column<int>(type: "integer", nullable: true, comment: "ราคาสมาชิกประเภท"),
                    mopid = table.Column<string>(type: "text", nullable: true, comment: "วิธีการชำระเงิน"),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    custtype = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "I", comment: "I = บุคคลธรรมดา C = นิติบุคคล"),
                    status = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "", comment: "สถานะลูกค้า"),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    prename = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "คำนำนหน้า"),
                    firstname = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "ชื่อ"),
                    midname = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "ชื่อกลาง่"),
                    lastname = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "นามสกุล"),
                    firstname2 = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "ชื่อ"),
                    midname2 = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "ชื่อกลาง่"),
                    lastname2 = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "นามสกุล"),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    sname1 = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "ชื่อย่อลูกค้า"),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    sname2 = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "ชื่อย่อลูกค้า2"),
                    taxid = table.Column<string>(type: "varchar(25)", nullable: true, defaultValue: "", comment: "เลขที่ผู้เสียภาษี"),
                    cid = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "สำนักงานใหญ่"),
                    headoffice = table.Column<string>(type: "text", nullable: true),
                    branchcode = table.Column<string>(type: "varchar(10)", nullable: true, defaultValue: "", comment: "รหัสสาขา"),
                    branchname = table.Column<string>(type: "varchar(255)", nullable: true, defaultValue: "", comment: "ชื่อสาขา"),
                    teletax = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "เบอร์โทรส่ง e-tax"),
                    tel = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "เบอร์โทรศัพท์"),
                    fax = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "โทรสาร"),
                    website = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "เว็บไซต์"),
                    singlelineaddress = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "ที่อยู่บรรทัดเดียว"),
                    singlelineaddress2 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "ที่อยู่บรรทัดเดียว 2"),
                    shippingby = table.Column<string>(type: "varchar(25)", nullable: true, defaultValue: "", comment: "จัดส่งโดย"),
                    bussinesstype = table.Column<string>(type: "varchar(255)", nullable: true, defaultValue: "", comment: "ประเภทธุรกิจ"),
                    creditdays = table.Column<decimal>(type: "numeric(18,0)", nullable: false, defaultValue: 0m, comment: "จำนวนวันเครดิต"),
                    creditamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "วงเงินเครดิต"),
                    bookbankno = table.Column<string>(type: "varchar(15)", nullable: true, defaultValue: "", comment: "เลขที่บัญชีธนาคาร"),
                    bookbankname = table.Column<string>(type: "varchar(100)", nullable: true, defaultValue: "", comment: "ชื่อที่บัญชีธนาคาร"),
                    bankbranch = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "สาขา"),
                    billingcond = table.Column<string>(type: "varchar(255)", nullable: true, defaultValue: "", comment: "เงื่อนไขการวางบิล"),
                    creditdaysbilling = table.Column<decimal>(type: "numeric(18,0)", nullable: false, defaultValue: 0m, comment: "จำนวนวันเครดิต(วางบิล)"),
                    receivingdatecond = table.Column<string>(type: "varchar(255)", nullable: true, defaultValue: "", comment: "เงื่อนไขวันเก็บเงิน"),
                    discountendbill = table.Column<string>(type: "varchar(100)", nullable: true, defaultValue: "", comment: "ส่วนลดท้ายบิล"),
                    discountitem = table.Column<string>(type: "varchar(100)", nullable: true, defaultValue: "", comment: "ส่วนลดที่รายการสินเค้า"),
                    currencyid = table.Column<string>(type: "text", nullable: true, comment: "หน่วยเงิน"),
                    promotioncode = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "โปรโมชั่น"),
                    vattype = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "ประเภทภาษี"),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "O", comment: "แยกนอก/รวมใน"),
                    vatrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "อัตราภาษี"),
                    remark1 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 1"),
                    Remark2 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 2"),
                    remark3 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 3"),
                    Remark4 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 4"),
                    remark5 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 5"),
                    remark6 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 6"),
                    remark7 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 7"),
                    remark8 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 8"),
                    remark9 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 9"),
                    remark10 = table.Column<string>(type: "varchar(1000)", nullable: true, defaultValue: "", comment: "หมายเหตุ 10"),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                    table.ForeignKey(
                        name: "FK_customer_acchart_receivableacchartid",
                        column: x => x.receivableacchartid,
                        principalTable: "acchart",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_bank_bankid",
                        column: x => x.bankid,
                        principalTable: "bank",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_custgroup_custgroupid",
                        column: x => x.custgroupid,
                        principalTable: "custgroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_membergroup_membergroupid",
                        column: x => x.membergroupid,
                        principalTable: "membergroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_salearea_saleareaid",
                        column: x => x.saleareaid,
                        principalTable: "salearea",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_saleteam_saleteamid",
                        column: x => x.saleteamid,
                        principalTable: "saleteam",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customer_segmentation_segmentationid",
                        column: x => x.segmentationid,
                        principalTable: "segmentation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bookbank",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    bankid = table.Column<int>(type: "integer", nullable: true),
                    bankbranchid = table.Column<int>(type: "integer", nullable: true),
                    acchartid = table.Column<int>(type: "integer", nullable: true, comment: "ผังบัญชี"),
                    recivecqacchartid = table.Column<int>(type: "integer", nullable: true, comment: "บัญชีเช็ครับ"),
                    paymentcqacchartid = table.Column<int>(type: "integer", nullable: true, comment: "บัญชีเช็คจ่าย"),
                    depositbookid = table.Column<int>(type: "integer", nullable: true, comment: "เล่มบันทึกใบนำฝาก"),
                    revertcqacchartid = table.Column<int>(type: "integer", nullable: true, comment: "กลับรายการเช็คจ่าย"),
                    trandferacchartid = table.Column<int>(type: "integer", nullable: true, comment: "บัญชีโอนเงินระหว่างสมุด"),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    bookno = table.Column<string>(type: "varchar(50)", nullable: true, defaultValue: "", comment: "เลขที่สมุดบัญชีธนาคาร"),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    sname1 = table.Column<string>(type: "varchar(150)", nullable: true, defaultValue: "", comment: "ชื่อย่อ 2"),
                    sname2 = table.Column<string>(type: "text", nullable: true),
                    bookbanktype = table.Column<string>(type: "varchar(2)", nullable: true, defaultValue: "", comment: "ประเภทสมุดบัญชี"),
                    opendate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    balanceamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, defaultValue: 0m, comment: "จำนวนเงินฝาก"),
                    blancedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Balance date"),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookbank", x => x.id);
                    table.ForeignKey(
                        name: "FK_bookbank_acchart_acchartid",
                        column: x => x.acchartid,
                        principalTable: "acchart",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bookbank_bank_bankid",
                        column: x => x.bankid,
                        principalTable: "bank",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bookbank_bankbranch_bankbranchid",
                        column: x => x.bankbranchid,
                        principalTable: "bankbranch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bookbank_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "shelf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    warehouseid = table.Column<int>(type: "integer", nullable: false),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name1 = table.Column<string>(type: "varchar(150)", nullable: false),
                    name2 = table.Column<string>(type: "varchar(150)", nullable: true),
                    width = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    length = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    height = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelf", x => x.id);
                    table.ForeignKey(
                        name: "FK_shelf_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_shelf_warehouse_warehouseid",
                        column: x => x.warehouseid,
                        principalTable: "warehouse",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "billtrnref",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: true),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    DocType = table.Column<int>(type: "integer", nullable: true),
                    ReceiptTrnHId = table.Column<int>(type: "integer", nullable: true),
                    ReceiptTrnDId = table.Column<int>(type: "integer", nullable: true),
                    invtrnhid = table.Column<int>(type: "integer", nullable: true),
                    InvTrnDId = table.Column<int>(type: "integer", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(50)", nullable: true),
                    itemreftype = table.Column<string>(type: "varchar(25)", nullable: true),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    rate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    bfcurrvatamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    bfstdvatamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatcurramount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatstdamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billtrnref", x => x.id);
                    table.ForeignKey(
                        name: "FK_billtrnref_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnref_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnref_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnref_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnref_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnref_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnref_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "doclink",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: true),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    MasterType = table.Column<int>(type: "integer", nullable: true),
                    MasterLinkId = table.Column<int>(type: "integer", nullable: true),
                    MasterItemLinkId = table.Column<int>(type: "integer", nullable: true),
                    childtype = table.Column<int>(type: "integer", nullable: false),
                    childlinkid = table.Column<int>(type: "integer", nullable: false),
                    childitemlinkid = table.Column<int>(type: "integer", nullable: false),
                    seq = table.Column<string>(type: "text", nullable: true),
                    qty = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doclink", x => x.id);
                    table.ForeignKey(
                        name: "FK_doclink_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_doclink_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_doclink_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_doclink_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_doclink_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_doclink_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_doclink_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "gltrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    accbookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: false),
                    departmentid = table.Column<int>(type: "integer", nullable: false),
                    projectid = table.Column<int>(type: "integer", nullable: false),
                    plansld = table.Column<int>(type: "integer", nullable: false),
                    freqacct = table.Column<string>(type: "varchar(25)", nullable: true),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    source = table.Column<string>(type: "varchar(6)", nullable: true),
                    detail01 = table.Column<string>(type: "varchar(255)", nullable: true),
                    detail02 = table.Column<string>(type: "varchar(255)", nullable: true),
                    detail03 = table.Column<string>(type: "varchar(255)", nullable: true),
                    detail04 = table.Column<string>(type: "varchar(255)", nullable: true),
                    detail05 = table.Column<string>(type: "varchar(255)", nullable: true),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    doccode = table.Column<string>(type: "varchar(25)", nullable: true),
                    approvedby = table.Column<string>(type: "varchar(25)", nullable: true),
                    approveddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    status = table.Column<string>(type: "varchar(4)", nullable: true),
                    islock = table.Column<string>(type: "varchar(2)", nullable: true),
                    debitamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    creditamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    bookkeeping = table.Column<string>(type: "varchar(1)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gltrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_gltrnh_accbook_accbookid",
                        column: x => x.accbookid,
                        principalTable: "accbook",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnh_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnh_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnh_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnh_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnh_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pricelist",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: true),
                    umid = table.Column<int>(type: "integer", nullable: true),
                    stdumid = table.Column<int>(type: "integer", nullable: true),
                    code = table.Column<string>(type: "varchar(10)", nullable: false),
                    pricelist_type = table.Column<string>(type: "varchar(1)", nullable: true),
                    qtystd = table.Column<int>(type: "integer", nullable: false),
                    qtysale = table.Column<int>(type: "integer", nullable: false),
                    price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    discountitem = table.Column<string>(type: "varchar(100)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactivedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    datasource = table.Column<string>(type: "varchar(50)", nullable: true),
                    exp_prod_name = table.Column<string>(type: "varchar(50)", nullable: true),
                    exp_stdum_per_umratio = table.Column<string>(type: "varchar(50)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pricelist", x => x.id);
                    table.ForeignKey(
                        name: "FK_pricelist_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pricelist_product_companyid",
                        column: x => x.companyid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productbarcode",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    Productumid = table.Column<int>(type: "integer", nullable: false),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    barcode = table.Column<string>(type: "varchar(100)", nullable: true),
                    stdprice = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice1 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice2 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice3 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice4 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice5 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice6 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice7 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice8 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productbarcode", x => x.id);
                    table.ForeignKey(
                        name: "FK_productbarcode_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productbarcode_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productsetdetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    productsetid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    settype = table.Column<string>(type: "varchar(1)", nullable: true),
                    qty = table.Column<int>(type: "integer", nullable: false),
                    umqty = table.Column<int>(type: "integer", nullable: false),
                    saleprice = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productsetdetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_productsetdetail_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productsetdetail_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productsetdetail_productset_productsetid",
                        column: x => x.productsetid,
                        principalTable: "productset",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productunit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    stdumid = table.Column<int>(type: "integer", nullable: false),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    qty = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    stdprice = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice1 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice2 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice3 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice4 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice5 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice6 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice7 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice8 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    defaultsale = table.Column<int>(type: "integer", nullable: false),
                    defaultbuy = table.Column<int>(type: "integer", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productunit", x => x.id);
                    table.ForeignKey(
                        name: "FK_productunit_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productunit_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "serial",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    warehouseid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(100)", nullable: false),
                    lot = table.Column<string>(type: "varchar(100)", nullable: true),
                    pstep = table.Column<int>(type: "integer", nullable: false),
                    sstep = table.Column<int>(type: "integer", nullable: false),
                    qty = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    umqty = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    seq = table.Column<string>(type: "varchar(4)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serial", x => x.id);
                    table.ForeignKey(
                        name: "FK_serial_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serial_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serial_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serial_warehouse_warehouseid",
                        column: x => x.warehouseid,
                        principalTable: "warehouse",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "serialtrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    refheadid = table.Column<int>(type: "integer", nullable: true),
                    refitemid = table.Column<int>(type: "integer", nullable: true),
                    productid = table.Column<int>(type: "integer", nullable: true),
                    warehouseid = table.Column<int>(type: "integer", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(4)", nullable: true),
                    calcflag = table.Column<int>(type: "integer", nullable: false),
                    serialcode = table.Column<string>(type: "varchar(25)", nullable: true),
                    shelfcode = table.Column<string>(type: "varchar(25)", nullable: true),
                    seq = table.Column<string>(type: "varchar(4)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serialtrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_serialtrnh_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serialtrnh_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serialtrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serialtrnh_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serialtrnh_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serialtrnh_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serialtrnh_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serialtrnh_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serialtrnh_warehouse_warehouseid",
                        column: x => x.warehouseid,
                        principalTable: "warehouse",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "serviceunit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    stdumid = table.Column<int>(type: "integer", nullable: false),
                    qty = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    stdprice = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice1 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice2 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice3 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice4 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice5 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice6 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice7 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice8 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    defaultsale = table.Column<int>(type: "integer", nullable: false),
                    defaultbuy = table.Column<int>(type: "integer", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceunit", x => x.id);
                    table.ForeignKey(
                        name: "FK_serviceunit_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serviceunit_service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "service",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ordertrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: false),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    warehouseid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    approvestatus = table.Column<string>(type: "varchar(2)", nullable: true),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    doccode = table.Column<string>(type: "varchar(25)", nullable: true),
                    docrefnumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(4)", nullable: true),
                    docisclosed = table.Column<string>(type: "varchar(2)", nullable: true),
                    doccloseddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    custaddr = table.Column<string>(type: "varchar(25)", nullable: true),
                    custdeliaddr = table.Column<string>(type: "varchar(25)", nullable: true),
                    custdeliaddredit = table.Column<string>(type: "varchar(500)", nullable: true),
                    currencyrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    approveby = table.Column<string>(type: "varchar(25)", nullable: true),
                    approveddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    remark01 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark02 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark03 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark04 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark05 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark06 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark07 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark08 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark09 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark10 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_01 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_02 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_03 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_04 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_05 = table.Column<string>(type: "varchar(255)", nullable: true),
                    sendby = table.Column<string>(type: "varchar(255)", nullable: true),
                    contactname = table.Column<string>(type: "varchar(150)", nullable: true),
                    creditterm = table.Column<int>(type: "integer", nullable: false),
                    duedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    estimatedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deliverydate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    vattype = table.Column<string>(type: "varchar(25)", nullable: true),
                    vatrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: true),
                    foottotalqty = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    footcurramt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrdiscstr = table.Column<string>(type: "varchar(100)", nullable: true),
                    footcurrdiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstddiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrafdiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdafdiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrwithouttaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdwithouttaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrwithtaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdwithtaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrbfvatamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdbfvatamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrvatamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdvatamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrnetamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdnetamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    refdoctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    refdoccode = table.Column<string>(type: "varchar(25)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordertrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_ordertrnh_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnh_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prereceipttrnref",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    prereceipttrnhid = table.Column<int>(type: "integer", nullable: true),
                    prereceipttrndid = table.Column<int>(type: "integer", nullable: true),
                    invtrnhid = table.Column<int>(type: "integer", nullable: true),
                    invtrndid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(50)", nullable: false),
                    docstatus = table.Column<string>(type: "varchar(150)", nullable: false),
                    itemreftype = table.Column<string>(type: "varchar(150)", nullable: true),
                    seq = table.Column<string>(type: "varchar(1)", nullable: true),
                    rate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    bfcurrvatamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    bfstdvatamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatcurramount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatstdamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Contactid = table.Column<int>(type: "integer", nullable: true),
                    Currencyid = table.Column<int>(type: "integer", nullable: true),
                    Customerid = table.Column<int>(type: "integer", nullable: true),
                    SaleManid = table.Column<int>(type: "integer", nullable: true),
                    Vendorid = table.Column<int>(type: "integer", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prereceipttrnref", x => x.id);
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_contact_Contactid",
                        column: x => x.Contactid,
                        principalTable: "contact",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_currency_Currencyid",
                        column: x => x.Currencyid,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_customer_Customerid",
                        column: x => x.Customerid,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_saleman_SaleManid",
                        column: x => x.SaleManid,
                        principalTable: "saleman",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnref_vendor_Vendorid",
                        column: x => x.Vendorid,
                        principalTable: "vendor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "pricelisttrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    pricelisttype = table.Column<string>(type: "varchar(150)", nullable: true),
                    active = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "active"),
                    inactive = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pricelisttrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_pricelisttrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pricelisttrnh_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productmembe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    customerid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    productumid = table.Column<int>(type: "integer", nullable: false),
                    stdprice = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice1 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice2 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice3 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice4 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice5 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice6 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice7 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice8 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    discount = table.Column<string>(type: "varchar(255)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productmembe", x => x.id);
                    table.ForeignKey(
                        name: "FK_productmembe_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productmembe_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productmembe_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "receipttrnref",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    receipttrnhid = table.Column<int>(type: "integer", nullable: true),
                    receipttrndid = table.Column<int>(type: "integer", nullable: true),
                    invtrnhid = table.Column<int>(type: "integer", nullable: true),
                    InvTrnDId = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(50)", nullable: false),
                    docstatus = table.Column<string>(type: "varchar(150)", nullable: false),
                    itemreftype = table.Column<string>(type: "varchar(150)", nullable: true),
                    seq = table.Column<string>(type: "varchar(1)", nullable: true),
                    rate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    bfcurrvatamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    bfstdvatamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatcurramount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatstdamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Contactid = table.Column<int>(type: "integer", nullable: true),
                    Currencyid = table.Column<int>(type: "integer", nullable: true),
                    Customerid = table.Column<int>(type: "integer", nullable: true),
                    SaleManid = table.Column<int>(type: "integer", nullable: true),
                    Vendorid = table.Column<int>(type: "integer", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receipttrnref", x => x.id);
                    table.ForeignKey(
                        name: "FK_receipttrnref_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnref_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnref_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnref_contact_Contactid",
                        column: x => x.Contactid,
                        principalTable: "contact",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_receipttrnref_currency_Currencyid",
                        column: x => x.Currencyid,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_receipttrnref_customer_Customerid",
                        column: x => x.Customerid,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_receipttrnref_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnref_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnref_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnref_saleman_SaleManid",
                        column: x => x.SaleManid,
                        principalTable: "saleman",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_receipttrnref_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnref_vendor_Vendorid",
                        column: x => x.Vendorid,
                        principalTable: "vendor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "servicemember",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    serviceid = table.Column<int>(type: "integer", nullable: true),
                    umid = table.Column<int>(type: "integer", nullable: true),
                    serviceumid = table.Column<int>(type: "integer", nullable: true),
                    stdprice = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice1 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice2 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice3 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice4 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice5 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice6 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice7 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    memberprice8 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    seq = table.Column<string>(type: "varchar(4)", nullable: true),
                    discount = table.Column<string>(type: "varchar(255)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicemember", x => x.id);
                    table.ForeignKey(
                        name: "FK_servicemember_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_servicemember_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_servicemember_service_serviceid",
                        column: x => x.serviceid,
                        principalTable: "service",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "whtrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhcaid = table.Column<int>(type: "integer", nullable: true),
                    refdoctype = table.Column<string>(type: "varchar(50)", nullable: true),
                    refdocid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    doccode = table.Column<string>(type: "varchar(25)", nullable: true),
                    docrefnumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(4)", nullable: true),
                    systype = table.Column<string>(type: "varchar(4)", nullable: true),
                    dateoffiling = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    taxdeduction = table.Column<string>(type: "varchar(25)", nullable: true),
                    whsection = table.Column<string>(type: "varchar(25)", nullable: true),
                    monthoffiling = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    taxseq = table.Column<string>(type: "varchar(10)", nullable: true),
                    totalpayamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    totaltaxvalue = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    totalvalueaftertax = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_whtrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_whtrnh_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnh_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnh_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_whtrnh_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnh_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnh_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnh_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnh_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "billtrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhcaid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    doccode = table.Column<string>(type: "varchar(25)", nullable: true),
                    docrefnumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(1)", nullable: true),
                    custsuppbranchcode = table.Column<string>(type: "varchar(10)", nullable: true),
                    custsupptaxid = table.Column<string>(type: "varchar(50)", nullable: true),
                    addressofficeid = table.Column<int>(type: "integer", nullable: false),
                    addressofficedetail = table.Column<string>(type: "varchar(100)", nullable: true),
                    contactname = table.Column<string>(type: "varchar(255)", nullable: true),
                    contactname2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    contacttel = table.Column<string>(type: "varchar(50)", nullable: true),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    paydate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    creditterm = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    islocked = table.Column<string>(type: "varchar(1)", nullable: true),
                    currencyrate = table.Column<decimal>(type: "numeric(18,6)", nullable: false),
                    vattype = table.Column<string>(type: "text", nullable: true),
                    vatrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatisout = table.Column<string>(type: "text", nullable: true),
                    remark01 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark02 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark03 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark04 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark05 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark06 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark07 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark08 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark09 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    remark10 = table.Column<string>(type: "varchar(1000)", nullable: true),
                    attach_file_01 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_02 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_03 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_04 = table.Column<string>(type: "varchar(255)", nullable: true),
                    attach_file_05 = table.Column<string>(type: "varchar(255)", nullable: true),
                    foottotalqty = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurramt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrwithholdingtaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdwithholdingtaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footdiscstr = table.Column<string>(type: "varchar(100)", nullable: true),
                    footcurrdiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstddiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrnetamt = table.Column<decimal>(type: "numeric", nullable: false),
                    footstdnetamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footcurrpayamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    footstdpayamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    cancellationreason = table.Column<string>(type: "varchar(1000)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billtrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_billtrnh_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_billtrnh_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnh_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "gltrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    accbookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    acchartid = table.Column<int>(type: "integer", nullable: false),
                    gltrnhid = table.Column<int>(type: "integer", nullable: false),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    group = table.Column<string>(type: "varchar(255)", nullable: true),
                    detail01 = table.Column<string>(type: "varchar(4000)", nullable: true),
                    detail02 = table.Column<string>(type: "varchar(4000)", nullable: true),
                    detail03 = table.Column<string>(type: "varchar(4000)", nullable: true),
                    detail04 = table.Column<string>(type: "varchar(4000)", nullable: true),
                    detail05 = table.Column<string>(type: "varchar(4000)", nullable: true),
                    creditamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    debitamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gltrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_gltrnd_accbook_accbookid",
                        column: x => x.accbookid,
                        principalTable: "accbook",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnd_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnd_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnd_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnd_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnd_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gltrnd_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "invtrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: false),
                    departmentid = table.Column<int>(type: "integer", nullable: false),
                    projectid = table.Column<int>(type: "integer", nullable: false),
                    plansld = table.Column<int>(type: "integer", nullable: false),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhcaid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    warehouseid = table.Column<int>(type: "integer", nullable: false),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true, comment: "ประเภทเอกสาร"),
                    doccode = table.Column<string>(type: "varchar(25)", nullable: false, comment: "เลขที่เอกสารภายใน"),
                    docrefnumber = table.Column<string>(type: "varchar(30)", nullable: false, comment: "เลขที่เอกสาร"),
                    docstatus = table.Column<string>(type: "varchar(4)", nullable: true, defaultValue: "Y", comment: "สถานะ"),
                    custsuppbranchcode = table.Column<string>(type: "varchar(1)", nullable: true, defaultValue: "Y", comment: "สาขา ลูกค้า/ผู้จำหน่าย"),
                    custsupptax = table.Column<string>(type: "varchar(25)", nullable: true, defaultValue: "Y", comment: "เลขประจำตัวผู้เสียภาษี ลูกค้า/ผู้จำหน่าย"),
                    addressofficeid = table.Column<string>(type: "varchar(1)", nullable: false, comment: "ที่อยู่ทำงาน"),
                    addressofficedetail = table.Column<string>(type: "varchar(1000)", nullable: false, comment: "ที่อยู่ทำงาน"),
                    addressdeliveryid = table.Column<int>(type: "integer", nullable: false),
                    addressdeliverydetail = table.Column<string>(type: "varchar(1)", nullable: true, comment: "ที่อยู่ส่งของ"),
                    contacttel = table.Column<string>(type: "varchar(255)", nullable: false, comment: "เบอร์โทรผู้ติดต่อ"),
                    shippingby = table.Column<string>(type: "varchar(25)", nullable: false, comment: "จัดส่งโดย"),
                    purchasedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    purchasecode = table.Column<string>(type: "varchar(25)", nullable: false, comment: "เลขที่สั่งซื้อ"),
                    IsRetProduct = table.Column<string>(type: "varchar(1)", nullable: false, comment: "ต้องการคืนสินค้า / ลดจำนวนเงินไม่คืนสินค้า"),
                    RetProductReason = table.Column<string>(type: "varchar(25)", nullable: false, comment: "สาเหตุการคืนสินค้า"),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    docdelidate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deliverycode = table.Column<string>(type: "varchar(25)", nullable: false, comment: "เลขที่ใบส่งสินค้า"),
                    docduedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    docvatdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    vattype = table.Column<string>(type: "varchar(25)", nullable: false, comment: "ภาษีมูลค่าเพิ่ม"),
                    vatrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "อัตราภาษีมูลค่าเพิ่ม"),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: false, comment: "แยกนอก/รวมใน"),
                    CreditTerm = table.Column<decimal>(type: "numeric(18,0)", nullable: false, comment: "เครดิตเทอม"),
                    taxrefund = table.Column<string>(type: "text", nullable: true),
                    vatdue = table.Column<string>(type: "varchar(1)", nullable: false, comment: "ภาษีมูลค่าเพิ่ม"),
                    islocked = table.Column<string>(type: "varchar(1)", nullable: false, comment: "ล็อครายการ"),
                    currencyrate = table.Column<decimal>(type: "numeric", nullable: false),
                    taxreportaddrid = table.Column<int>(type: "integer", nullable: false),
                    approvedby = table.Column<string>(type: "varchar(25)", nullable: false, comment: "ผู้อนุมัติเอกสาร"),
                    approveddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    remark01 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 01"),
                    remark02 = table.Column<string>(type: "varchar(225)", nullable: false, comment: "หมายเหตุ 02"),
                    remark03 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 03"),
                    remark04 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 04"),
                    remark05 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 05"),
                    remark06 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 06"),
                    remark07 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 07"),
                    remark08 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 08"),
                    remark09 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 09"),
                    remark10 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "หมายเหตุ 10"),
                    attach_file_01 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "เก็บเฉพาะชื่อไฟล์เท่านั้น"),
                    attach_file_02 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "เก็บเฉพาะชื่อไฟล์เท่านั้น"),
                    attach_file_03 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "เก็บเฉพาะชื่อไฟล์เท่านั้น"),
                    attach_file_04 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "เก็บเฉพาะชื่อไฟล์เท่านั้น"),
                    attach_file_05 = table.Column<string>(type: "varchar(255)", nullable: false, comment: "เก็บเฉพาะชื่อไฟล์เท่านั้น"),
                    footcurrdisamtitem = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าส่วนลด(Currency)"),
                    footstddisamtitem = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าส่วนลด(Standard)"),
                    footcurrpayamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวนเงินที่จ่าย(Currency)"),
                    footstdpayamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวนเงินที่จ่าย(Standard)"),
                    foottotalqty = table.Column<decimal>(type: "numeric(18,0)", nullable: false, comment: "จำนวนสินค้าทั้งหมด"),
                    footcurramt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสินค้า"),
                    footstdamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสินค้า"),
                    footcurrdiscstr = table.Column<string>(type: "varchar(100)", nullable: false, comment: "ส่วนลดท้ายบิล"),
                    footcurrdiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "ส่วนลดท้ายบิล"),
                    footstddiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "ส่วนลดท้ายบิล"),
                    footcurrafdiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าหลังหักส่วนลด"),
                    footstdafdiscamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าหลังหักส่วนลด"),
                    footdepositamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าเงินมัดจำ"),
                    footcurrafdepositamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าหลัง หัก เงินมัดจำ"),
                    footstdafdepositamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าหลัง หัก เงินมัดจำ"),
                    footcurrwithouttaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสินค้าไม่มีภาษี"),
                    footstdwithouttaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสินค้าไม่มีภาษี"),
                    footcurrwithtaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสินค้ามีภาษี"),
                    footstdwithtaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสินค้ามีภาษี"),
                    footcurrbfvatamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสินค้าก่อนภาษี"),
                    footstdbfvatamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสินค้าก่อนภาษี"),
                    footcurrvatamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าภาษี"),
                    footstdvatamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าภาษี"),
                    footwithholdingtaxamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "ภาษีหัก ณ ที่จ่าย"),
                    footcurrnetamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสุทธิ(Currency)"),
                    footstdnetamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าสุทธิ(Standard)"),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invtrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_invtrnh_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_invtrnh_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnh_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    bankid = table.Column<int>(type: "integer", nullable: true),
                    bankbranchid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    custvendorid = table.Column<int>(type: "integer", nullable: true),
                    systype = table.Column<string>(type: "varchar(25)", nullable: true),
                    depositwithdraw = table.Column<string>(type: "varchar(1)", nullable: true),
                    paytype = table.Column<string>(type: "text", nullable: true),
                    paygroup = table.Column<string>(type: "varchar(1)", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    tobankdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    duedate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    code = table.Column<string>(type: "varchar(25)", nullable: true),
                    payrecv = table.Column<string>(type: "varchar(255)", nullable: true),
                    payrecv2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    paynameincheque = table.Column<string>(type: "varchar(255)", nullable: true),
                    paynameincheque2 = table.Column<string>(type: "varchar(255)", nullable: true),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    payamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    acpayee = table.Column<string>(type: "varchar(1)", nullable: true),
                    orderbearer = table.Column<string>(type: "varchar(1)", nullable: true),
                    stat = table.Column<string>(type: "varchar(1)", nullable: true),
                    step = table.Column<string>(type: "varchar(1)", nullable: true),
                    inout = table.Column<string>(type: "varchar(1)", nullable: true),
                    returnattime = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    paydate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    passdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    returndate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    chequereturncode = table.Column<string>(type: "varchar(25)", nullable: true),
                    remark01 = table.Column<string>(type: "varchar(500)", nullable: true),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.id);
                    table.ForeignKey(
                        name: "FK_payment_bank_bankid",
                        column: x => x.bankid,
                        principalTable: "bank",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payment_bankbranch_bankbranchid",
                        column: x => x.bankbranchid,
                        principalTable: "bankbranch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payment_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payment_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payment_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payment_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payment_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prereceipttrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhcaid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(50)", nullable: false),
                    doccode = table.Column<string>(type: "varchar(150)", nullable: false),
                    docrefnumber = table.Column<string>(type: "varchar(150)", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(1)", nullable: true),
                    custsuppbranchcode = table.Column<string>(type: "varchar(1)", nullable: true),
                    custsupptaxid = table.Column<string>(type: "varchar(1)", nullable: true),
                    addressofficeid = table.Column<int>(type: "integer", nullable: false),
                    addressofficedetail = table.Column<string>(type: "varchar(1)", nullable: true),
                    contactname = table.Column<string>(type: "varchar(1)", nullable: true),
                    contactname2 = table.Column<string>(type: "varchar(1)", nullable: true),
                    contacttel = table.Column<string>(type: "varchar(1)", nullable: true),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Refdocdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    refdoccode = table.Column<string>(type: "varchar(1)", nullable: true),
                    islocked = table.Column<string>(type: "varchar(1)", nullable: true),
                    currencycode = table.Column<string>(type: "varchar(1)", nullable: true),
                    currencyrate = table.Column<decimal>(type: "numeric", nullable: false),
                    vattype = table.Column<string>(type: "varchar(1)", nullable: true),
                    vatrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark01 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark02 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark03 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark04 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark05 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark06 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark07 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark08 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark09 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark10 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_01 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_02 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_03 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_04 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_05 = table.Column<string>(type: "varchar(1)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prereceipttrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnh_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "receipttrnh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: true),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhcaid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(50)", nullable: false),
                    doccode = table.Column<string>(type: "varchar(150)", nullable: false),
                    docrefnumber = table.Column<string>(type: "varchar(150)", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(1)", nullable: true),
                    custsuppbranchcode = table.Column<string>(type: "varchar(1)", nullable: true),
                    custsupptaxid = table.Column<string>(type: "varchar(1)", nullable: true),
                    addressofficeid = table.Column<int>(type: "integer", nullable: false),
                    addressofficedetail = table.Column<string>(type: "varchar(1)", nullable: true),
                    contactname = table.Column<string>(type: "varchar(1)", nullable: true),
                    contactname2 = table.Column<string>(type: "varchar(1)", nullable: true),
                    contacttel = table.Column<string>(type: "varchar(1)", nullable: true),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    refdocdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    refdoccode = table.Column<string>(type: "varchar(1)", nullable: true),
                    islocked = table.Column<string>(type: "varchar(1)", nullable: true),
                    currencycode = table.Column<string>(type: "varchar(1)", nullable: true),
                    currencyrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vattype = table.Column<string>(type: "varchar(1)", nullable: true),
                    vatrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark01 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark02 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark03 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark04 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark05 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark06 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark07 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark08 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark09 = table.Column<string>(type: "varchar(1)", nullable: true),
                    remark10 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_01 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_02 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_03 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_04 = table.Column<string>(type: "varchar(1)", nullable: true),
                    attach_file_05 = table.Column<string>(type: "varchar(1)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receipttrnh", x => x.id);
                    table.ForeignKey(
                        name: "FK_receipttrnh_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_receipttrnh_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnh_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ordertrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    ordertrnhid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    warehouseid = table.Column<int>(type: "integer", nullable: false),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    umstdid = table.Column<int>(type: "integer", nullable: false),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    type = table.Column<string>(type: "varchar(1)", nullable: true),
                    prodtype = table.Column<string>(type: "varchar(25)", nullable: true),
                    remark01 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark02 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark03 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark04 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark05 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark06 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark07 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark08 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark09 = table.Column<string>(type: "varchar(255)", nullable: true),
                    remark10 = table.Column<string>(type: "varchar(255)", nullable: true),
                    lot = table.Column<string>(type: "varchar(30)", nullable: true),
                    qty = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    backqty = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    stdqty = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    discstr = table.Column<string>(type: "varchar(25)", nullable: true),
                    discamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    vattype = table.Column<string>(type: "varchar(25)", nullable: true),
                    vatrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    deliverydate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: true),
                    parent = table.Column<string>(type: "varchar(25)", nullable: true),
                    child = table.Column<string>(type: "varchar(25)", nullable: true),
                    status = table.Column<string>(type: "varchar(4)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordertrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_ordertrnd_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_ordertrnh_ordertrnhid",
                        column: x => x.ordertrnhid,
                        principalTable: "ordertrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ordertrnd_warehouse_warehouseid",
                        column: x => x.warehouseid,
                        principalTable: "warehouse",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pricelisttrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    pricelisttrnhid = table.Column<int>(type: "integer", nullable: true),
                    productid = table.Column<int>(type: "integer", nullable: true),
                    stdumid = table.Column<int>(type: "integer", nullable: true),
                    umid = table.Column<int>(type: "integer", nullable: true),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    qtystd = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    qtysale = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    discountitem = table.Column<string>(type: "varchar(100)", nullable: true),
                    exp_prod_name = table.Column<string>(type: "varchar(100)", nullable: true),
                    exp_stdum_per_umratio = table.Column<string>(type: "varchar(100)", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pricelisttrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_pricelisttrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pricelisttrnd_pricelisttrnh_pricelisttrnhid",
                        column: x => x.pricelisttrnhid,
                        principalTable: "pricelisttrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pricelisttrnd_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "whtrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    whtrnhid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(4)", nullable: true),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    incometype = table.Column<string>(type: "varchar(25)", nullable: true),
                    payamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    taxrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    taxvalue = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    valueaftertax = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_whtrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_whtrnd_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnd_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnd_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnd_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnd_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnd_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whtrnd_whtrnh_whtrnhid",
                        column: x => x.whtrnhid,
                        principalTable: "whtrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "billtrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhcaid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    billtrnhid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(50)", nullable: true),
                    receipttrnhid = table.Column<string>(type: "varchar(25)", nullable: true),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(50)", nullable: true),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    refinvoicelinkid = table.Column<string>(type: "varchar(100)", nullable: true),
                    refinvoicedoctype = table.Column<string>(type: "varchar(100)", nullable: true),
                    refinvoicedocgroup = table.Column<string>(type: "varchar(100)", nullable: true),
                    partialtype = table.Column<int>(type: "integer", nullable: false),
                    amount = table.Column<string>(type: "varchar(100)", nullable: false),
                    payamt = table.Column<string>(type: "varchar(100)", nullable: false),
                    depositamt = table.Column<string>(type: "varchar(100)", nullable: false),
                    whtamt = table.Column<string>(type: "varchar(255)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billtrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_billtrnd_billtrnh_billtrnhid",
                        column: x => x.billtrnhid,
                        principalTable: "billtrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_billtrnd_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_billtrnd_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "invtrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true, comment: "บัญชีรายวัน"),
                    invtrnhid = table.Column<int>(type: "integer", nullable: true, comment: "เลขที่ใบแจ้งหนี้ส่วนหัวเอกสาร"),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    warehouseid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    umid = table.Column<int>(type: "integer", nullable: false),
                    umstdid = table.Column<int>(type: "integer", nullable: false),
                    doctype = table.Column<string>(type: "varchar(4)", nullable: false, comment: "ประเภทเอกสาร"),
                    docstatus = table.Column<string>(type: "varchar(4)", nullable: true, comment: "สถานะ"),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    docdeliverydate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    pstype = table.Column<string>(type: "varchar(25)", nullable: true, comment: "(P)สินค้า/(S)ชุดสินค้า"),
                    Refund = table.Column<string>(type: "varchar(1)", nullable: true, comment: "Y = คืน , N = ไม่คืน"),
                    ProdType = table.Column<string>(type: "varchar(25)", nullable: true, comment: "ประเภทสินค้า"),
                    inouttype = table.Column<string>(type: "varchar(1)", nullable: true, comment: "นำเข้า/ส่งออก"),
                    rootseq = table.Column<string>(type: "varchar(2)", nullable: true, comment: "ลำดับชั้นชุดสินค้า"),
                    setparent = table.Column<string>(type: "varchar(25)", nullable: true, comment: "ชุดสินค้าตัวคุมสินค้า"),
                    qty = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวน"),
                    backqty = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวนตัดคงเหลือ"),
                    qtystd = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวนมาตรฐาน"),
                    price = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "ราคา"),
                    pricek = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "ราคา(คีย์)"),
                    discstr = table.Column<string>(type: "varchar(25)", nullable: true, comment: "ส่วนลด(คีย์)"),
                    discamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าส่วนลด"),
                    discamountk = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าส่วนลด(คีย์)"),
                    xrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "อัตราแปลงหน่วย"),
                    bfvatamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวน(qty) x ราคาต่อหน่วย(price) - ส่วนลด(discamt)"),
                    bfvatamountk = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวน(qty) x ราคาต่อหน่วย(price) - ส่วนลด(discamt)"),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "Before VAT amount + จำนวนภาษี"),
                    amountk = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวน(qty) x ราคาต่อหน่วย(pricek) - ส่วนลด(DiscAmtK)"),
                    vattype = table.Column<string>(type: "varchar(1)", nullable: true, comment: "ประเภทภาษี"),
                    vatisout = table.Column<string>(type: "varchar(1)", nullable: true, comment: "แยกนอก/รวมใน"),
                    vatrate = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "อัตตราภาษี"),
                    vatamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวนภาษี"),
                    vatamountk = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "จำนวนภาษี(คีย์)"),
                    lot = table.Column<string>(type: "varchar(30)", nullable: true, comment: "ฉลาก"),
                    mfgdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    expdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Seq = table.Column<string>(type: "varchar(4)", nullable: false, comment: "ลำดับรายการ"),
                    remark01 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 01"),
                    remark02 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 02"),
                    remark03 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 03"),
                    remark04 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 04"),
                    remark05 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 05"),
                    remark06 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 06"),
                    remark07 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 07"),
                    remark08 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 08"),
                    remark09 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 09"),
                    remark10 = table.Column<string>(type: "varchar(255)", nullable: true, comment: "Item remark 10"),
                    costamount = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าต้นทุน"),
                    costadj = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าต้นทุนเพิ่มเติม"),
                    costavg = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าต้นทุนเฉลี่ย"),
                    costfifo = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าต้นทุน FIFO"),
                    costlot = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าต้นทุน lot"),
                    coststd = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าต้นทุน Std."),
                    calflag = table.Column<int>(type: "integer", nullable: false),
                    refdochid = table.Column<int>(type: "integer", nullable: false),
                    refdoctype = table.Column<string>(type: "text", nullable: true),
                    refdocdid = table.Column<int>(type: "integer", nullable: false),
                    refdocqtyofcut = table.Column<decimal>(type: "numeric(18,0)", nullable: false, comment: "จำนวนที่ดึงมาตัดในเอกสารใบนี้"),
                    paycurramt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าชำระ"),
                    paystdamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "มูลค่าชำระ"),
                    Contactid = table.Column<int>(type: "integer", nullable: true),
                    SaleManid = table.Column<int>(type: "integer", nullable: true),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invtrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_invtrnd_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_contact_Contactid",
                        column: x => x.Contactid,
                        principalTable: "contact",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_invtrnd_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_invtrnh_invtrnhid",
                        column: x => x.invtrnhid,
                        principalTable: "invtrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_product_productid",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_saleman_SaleManid",
                        column: x => x.SaleManid,
                        principalTable: "saleman",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_invtrnd_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invtrnd_warehouse_warehouseid",
                        column: x => x.warehouseid,
                        principalTable: "warehouse",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "payintrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    stat = table.Column<string>(type: "varchar(1)", nullable: true),
                    payintrnhid = table.Column<int>(type: "integer", nullable: true),
                    paymentid = table.Column<int>(type: "integer", nullable: true),
                    seq = table.Column<int>(type: "integer", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payintrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_payintrnd_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payintrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payintrnd_payment_paymentid",
                        column: x => x.paymentid,
                        principalTable: "payment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prereceipttrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhcaid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    prereceipttrnhid = table.Column<int>(type: "integer", nullable: false),
                    receipttrnhid = table.Column<int>(type: "integer", nullable: true),
                    doctype = table.Column<string>(type: "varchar(50)", nullable: false),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(150)", nullable: false),
                    Seq = table.Column<string>(type: "varchar(150)", nullable: true),
                    refdocheadid = table.Column<int>(type: "integer", nullable: false),
                    refdocheaddoctype = table.Column<string>(type: "varchar(1)", nullable: true),
                    refdocitemid = table.Column<string>(type: "varchar(1)", nullable: true),
                    refinvoiceid = table.Column<int>(type: "integer", nullable: false),
                    refinvoicedoctype = table.Column<string>(type: "text", nullable: true),
                    refinvoicedocgroup = table.Column<string>(type: "varchar(1)", nullable: true),
                    partialtype = table.Column<int>(type: "integer", nullable: false),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    payamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    depositamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    whtamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prereceipttrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_prereceipttrnh_prereceipttrnhid",
                        column: x => x.prereceipttrnhid,
                        principalTable: "prereceipttrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prereceipttrnd_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "receipttrnd",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    branchid = table.Column<int>(type: "integer", nullable: false),
                    bookid = table.Column<int>(type: "integer", nullable: false),
                    sectionid = table.Column<int>(type: "integer", nullable: true),
                    departmentid = table.Column<int>(type: "integer", nullable: true),
                    projectid = table.Column<int>(type: "integer", nullable: true),
                    plansld = table.Column<int>(type: "integer", nullable: true),
                    gltrnhid = table.Column<int>(type: "integer", nullable: true),
                    gltrnhcaid = table.Column<int>(type: "integer", nullable: true),
                    customerid = table.Column<int>(type: "integer", nullable: true),
                    vendorid = table.Column<int>(type: "integer", nullable: true),
                    contactid = table.Column<int>(type: "integer", nullable: true),
                    salemanid = table.Column<int>(type: "integer", nullable: true),
                    currencyid = table.Column<int>(type: "integer", nullable: true),
                    receipttrnhid = table.Column<int>(type: "integer", nullable: false),
                    doctype = table.Column<string>(type: "varchar(50)", nullable: false),
                    docdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    docstatus = table.Column<string>(type: "varchar(150)", nullable: false),
                    seq = table.Column<string>(type: "varchar(150)", nullable: true),
                    RefDocHeadId = table.Column<int>(type: "integer", nullable: false),
                    refdocheaddoctype = table.Column<string>(type: "varchar(1)", nullable: true),
                    refdocitemid = table.Column<string>(type: "varchar(1)", nullable: true),
                    refinvoiceid = table.Column<int>(type: "integer", nullable: false),
                    refinvoicedoctype = table.Column<string>(type: "varchar(1)", nullable: true),
                    refinvoicedocgroup = table.Column<string>(type: "varchar(1)", nullable: true),
                    partialtype = table.Column<int>(type: "integer", nullable: false),
                    amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    payamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    depositamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    whtamt = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: true),
                    createatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updateby = table.Column<string>(type: "text", nullable: true),
                    updateatutc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createapp = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receipttrnd", x => x.id);
                    table.ForeignKey(
                        name: "FK_receipttrnd_book_bookid",
                        column: x => x.bookid,
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_branch_branchid",
                        column: x => x.branchid,
                        principalTable: "branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_company_companyid",
                        column: x => x.companyid,
                        principalTable: "company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_contact_contactid",
                        column: x => x.contactid,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_currency_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_customer_customerid",
                        column: x => x.customerid,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_department_departmentid",
                        column: x => x.departmentid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_gltrnh_gltrnhid",
                        column: x => x.gltrnhid,
                        principalTable: "gltrnh",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_receipttrnd_plans_plansld",
                        column: x => x.plansld,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_project_projectid",
                        column: x => x.projectid,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_receipttrnh_receipttrnhid",
                        column: x => x.receipttrnhid,
                        principalTable: "receipttrnh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_saleman_salemanid",
                        column: x => x.salemanid,
                        principalTable: "saleman",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_section_sectionid",
                        column: x => x.sectionid,
                        principalTable: "section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_receipttrnd_vendor_vendorid",
                        column: x => x.vendorid,
                        principalTable: "vendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accbook_companyid",
                table: "accbook",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_acchart_companyid",
                table: "acchart",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_accrole_companyid",
                table: "accrole",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_accroletemplated_acchartid",
                table: "accroletemplated",
                column: "acchartid");

            migrationBuilder.CreateIndex(
                name: "IX_accroletemplated_accroletemplatehid",
                table: "accroletemplated",
                column: "accroletemplatehid");

            migrationBuilder.CreateIndex(
                name: "IX_accroletemplateh_companyid",
                table: "accroletemplateh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_asset_acchartid",
                table: "asset",
                column: "acchartid");

            migrationBuilder.CreateIndex(
                name: "IX_asset_assetgroupid",
                table: "asset",
                column: "assetgroupid");

            migrationBuilder.CreateIndex(
                name: "IX_asset_branchid",
                table: "asset",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_asset_companyid",
                table: "asset",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_assetgroup_acchartid",
                table: "assetgroup",
                column: "acchartid");

            migrationBuilder.CreateIndex(
                name: "IX_assetgroup_companyid",
                table: "assetgroup",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_bank_companyid",
                table: "bank",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_bankbranch_bankid",
                table: "bankbranch",
                column: "bankid");

            migrationBuilder.CreateIndex(
                name: "IX_bankbranch_companyid",
                table: "bankbranch",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_billtrnhid",
                table: "billtrnd",
                column: "billtrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_bookid",
                table: "billtrnd",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_branchid",
                table: "billtrnd",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_companyid",
                table: "billtrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_contactid",
                table: "billtrnd",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_currencyid",
                table: "billtrnd",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_customerid",
                table: "billtrnd",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_departmentid",
                table: "billtrnd",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_gltrnhid",
                table: "billtrnd",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_plansld",
                table: "billtrnd",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_projectid",
                table: "billtrnd",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_salemanid",
                table: "billtrnd",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_sectionid",
                table: "billtrnd",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnd_vendorid",
                table: "billtrnd",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_bookid",
                table: "billtrnh",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_branchid",
                table: "billtrnh",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_companyid",
                table: "billtrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_contactid",
                table: "billtrnh",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_currencyid",
                table: "billtrnh",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_customerid",
                table: "billtrnh",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_departmentid",
                table: "billtrnh",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_gltrnhid",
                table: "billtrnh",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_plansld",
                table: "billtrnh",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_projectid",
                table: "billtrnh",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_salemanid",
                table: "billtrnh",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_sectionid",
                table: "billtrnh",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnh_vendorid",
                table: "billtrnh",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnref_bookid",
                table: "billtrnref",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnref_branchid",
                table: "billtrnref",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnref_companyid",
                table: "billtrnref",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnref_departmentid",
                table: "billtrnref",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnref_plansld",
                table: "billtrnref",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnref_projectid",
                table: "billtrnref",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_billtrnref_sectionid",
                table: "billtrnref",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_bilpay_branchid",
                table: "bilpay",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_bilpay_companyid",
                table: "bilpay",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_book_accbookid",
                table: "book",
                column: "accbookid");

            migrationBuilder.CreateIndex(
                name: "IX_book_accroletemplatehid",
                table: "book",
                column: "accroletemplatehid");

            migrationBuilder.CreateIndex(
                name: "IX_book_branchid",
                table: "book",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_book_companyid",
                table: "book",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_bookbank_acchartid",
                table: "bookbank",
                column: "acchartid");

            migrationBuilder.CreateIndex(
                name: "IX_bookbank_bankbranchid",
                table: "bookbank",
                column: "bankbranchid");

            migrationBuilder.CreateIndex(
                name: "IX_bookbank_bankid",
                table: "bookbank",
                column: "bankid");

            migrationBuilder.CreateIndex(
                name: "IX_bookbank_companyid",
                table: "bookbank",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_branch_companyid",
                table: "branch",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_brand_companyid",
                table: "brand",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_category_companyid",
                table: "category",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_color_companyid",
                table: "color",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_contact_companyid",
                table: "contact",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_currency_companyid",
                table: "currency",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_custgroup_acchartid",
                table: "custgroup",
                column: "acchartid");

            migrationBuilder.CreateIndex(
                name: "IX_custgroup_companyid",
                table: "custgroup",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_customecredit_companyid",
                table: "customecredit",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_bankid",
                table: "customer",
                column: "bankid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_companyid",
                table: "customer",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_custgroupid",
                table: "customer",
                column: "custgroupid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_membergroupid",
                table: "customer",
                column: "membergroupid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_receivableacchartid",
                table: "customer",
                column: "receivableacchartid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_saleareaid",
                table: "customer",
                column: "saleareaid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_salemanid",
                table: "customer",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_saleteamid",
                table: "customer",
                column: "saleteamid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_segmentationid",
                table: "customer",
                column: "segmentationid");

            migrationBuilder.CreateIndex(
                name: "IX_department_companyid",
                table: "department",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_department_sectionid",
                table: "department",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_description_companyid",
                table: "description",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_design_companyid",
                table: "design",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_doclink_bookid",
                table: "doclink",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_doclink_branchid",
                table: "doclink",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_doclink_companyid",
                table: "doclink",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_doclink_departmentid",
                table: "doclink",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_doclink_plansld",
                table: "doclink",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_doclink_projectid",
                table: "doclink",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_doclink_sectionid",
                table: "doclink",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_format_companyid",
                table: "format",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_formmaster_companyid",
                table: "formmaster",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_fromref_companyid",
                table: "fromref",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnd_accbookid",
                table: "gltrnd",
                column: "accbookid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnd_branchid",
                table: "gltrnd",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnd_companyid",
                table: "gltrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnd_departmentid",
                table: "gltrnd",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnd_gltrnhid",
                table: "gltrnd",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnd_plansld",
                table: "gltrnd",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnd_projectid",
                table: "gltrnd",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnd_sectionid",
                table: "gltrnd",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnh_accbookid",
                table: "gltrnh",
                column: "accbookid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnh_branchid",
                table: "gltrnh",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnh_companyid",
                table: "gltrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnh_departmentid",
                table: "gltrnh",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnh_plansld",
                table: "gltrnh",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnh_projectid",
                table: "gltrnh",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_gltrnh_sectionid",
                table: "gltrnh",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_grade_companyid",
                table: "grade",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_bookid",
                table: "invtrnd",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_branchid",
                table: "invtrnd",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_companyid",
                table: "invtrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_Contactid",
                table: "invtrnd",
                column: "Contactid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_customerid",
                table: "invtrnd",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_departmentid",
                table: "invtrnd",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_invtrnhid",
                table: "invtrnd",
                column: "invtrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_plansld",
                table: "invtrnd",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_productid",
                table: "invtrnd",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_projectid",
                table: "invtrnd",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_SaleManid",
                table: "invtrnd",
                column: "SaleManid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_sectionid",
                table: "invtrnd",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_vendorid",
                table: "invtrnd",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnd_warehouseid",
                table: "invtrnd",
                column: "warehouseid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_bookid",
                table: "invtrnh",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_branchid",
                table: "invtrnh",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_companyid",
                table: "invtrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_contactid",
                table: "invtrnh",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_currencyid",
                table: "invtrnh",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_customerid",
                table: "invtrnh",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_departmentid",
                table: "invtrnh",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_gltrnhid",
                table: "invtrnh",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_plansld",
                table: "invtrnh",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_projectid",
                table: "invtrnh",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_salemanid",
                table: "invtrnh",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_sectionid",
                table: "invtrnh",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_invtrnh_vendorid",
                table: "invtrnh",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_membergroup_companyid",
                table: "membergroup",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_model_companyid",
                table: "model",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_mop_companyid",
                table: "mop",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_bookid",
                table: "ordertrnd",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_branchid",
                table: "ordertrnd",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_companyid",
                table: "ordertrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_contactid",
                table: "ordertrnd",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_currencyid",
                table: "ordertrnd",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_customerid",
                table: "ordertrnd",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_departmentid",
                table: "ordertrnd",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_ordertrnhid",
                table: "ordertrnd",
                column: "ordertrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_plansld",
                table: "ordertrnd",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_productid",
                table: "ordertrnd",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_projectid",
                table: "ordertrnd",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_salemanid",
                table: "ordertrnd",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_sectionid",
                table: "ordertrnd",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_vendorid",
                table: "ordertrnd",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnd_warehouseid",
                table: "ordertrnd",
                column: "warehouseid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_bookid",
                table: "ordertrnh",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_branchid",
                table: "ordertrnh",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_companyid",
                table: "ordertrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_contactid",
                table: "ordertrnh",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_currencyid",
                table: "ordertrnh",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_customerid",
                table: "ordertrnh",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_departmentid",
                table: "ordertrnh",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_plansld",
                table: "ordertrnh",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_projectid",
                table: "ordertrnh",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_salemanid",
                table: "ordertrnh",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_sectionid",
                table: "ordertrnh",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_ordertrnh_vendorid",
                table: "ordertrnh",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_payintrnd_branchid",
                table: "payintrnd",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_payintrnd_companyid",
                table: "payintrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_payintrnd_paymentid",
                table: "payintrnd",
                column: "paymentid");

            migrationBuilder.CreateIndex(
                name: "IX_payment_bankbranchid",
                table: "payment",
                column: "bankbranchid");

            migrationBuilder.CreateIndex(
                name: "IX_payment_bankid",
                table: "payment",
                column: "bankid");

            migrationBuilder.CreateIndex(
                name: "IX_payment_branchid",
                table: "payment",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_payment_companyid",
                table: "payment",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_payment_customerid",
                table: "payment",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_payment_gltrnhid",
                table: "payment",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_payment_vendorid",
                table: "payment",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_plans_companyid",
                table: "plans",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_positions_companyid",
                table: "positions",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_bookid",
                table: "prereceipttrnd",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_branchid",
                table: "prereceipttrnd",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_companyid",
                table: "prereceipttrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_contactid",
                table: "prereceipttrnd",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_currencyid",
                table: "prereceipttrnd",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_customerid",
                table: "prereceipttrnd",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_departmentid",
                table: "prereceipttrnd",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_gltrnhid",
                table: "prereceipttrnd",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_plansld",
                table: "prereceipttrnd",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_prereceipttrnhid",
                table: "prereceipttrnd",
                column: "prereceipttrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_projectid",
                table: "prereceipttrnd",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_salemanid",
                table: "prereceipttrnd",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_sectionid",
                table: "prereceipttrnd",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnd_vendorid",
                table: "prereceipttrnd",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_bookid",
                table: "prereceipttrnh",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_branchid",
                table: "prereceipttrnh",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_companyid",
                table: "prereceipttrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_contactid",
                table: "prereceipttrnh",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_currencyid",
                table: "prereceipttrnh",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_customerid",
                table: "prereceipttrnh",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_departmentid",
                table: "prereceipttrnh",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_gltrnhid",
                table: "prereceipttrnh",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_plansld",
                table: "prereceipttrnh",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_projectid",
                table: "prereceipttrnh",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_salemanid",
                table: "prereceipttrnh",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_sectionid",
                table: "prereceipttrnh",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnh_vendorid",
                table: "prereceipttrnh",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_bookid",
                table: "prereceipttrnref",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_branchid",
                table: "prereceipttrnref",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_companyid",
                table: "prereceipttrnref",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_Contactid",
                table: "prereceipttrnref",
                column: "Contactid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_Currencyid",
                table: "prereceipttrnref",
                column: "Currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_Customerid",
                table: "prereceipttrnref",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_departmentid",
                table: "prereceipttrnref",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_plansld",
                table: "prereceipttrnref",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_projectid",
                table: "prereceipttrnref",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_SaleManid",
                table: "prereceipttrnref",
                column: "SaleManid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_sectionid",
                table: "prereceipttrnref",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_prereceipttrnref_Vendorid",
                table: "prereceipttrnref",
                column: "Vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_pricelist_companyid",
                table: "pricelist",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_pricelisttrnd_companyid",
                table: "pricelisttrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_pricelisttrnd_pricelisttrnhid",
                table: "pricelisttrnd",
                column: "pricelisttrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_pricelisttrnd_productid",
                table: "pricelisttrnd",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_pricelisttrnh_companyid",
                table: "pricelisttrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_pricelisttrnh_customerid",
                table: "pricelisttrnh",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_product_brandid",
                table: "product",
                column: "brandid");

            migrationBuilder.CreateIndex(
                name: "IX_product_categoryid",
                table: "product",
                column: "categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_product_colorid",
                table: "product",
                column: "colorid");

            migrationBuilder.CreateIndex(
                name: "IX_product_companyid",
                table: "product",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_product_designid",
                table: "product",
                column: "designid");

            migrationBuilder.CreateIndex(
                name: "IX_product_formatid",
                table: "product",
                column: "formatid");

            migrationBuilder.CreateIndex(
                name: "IX_product_gradeid",
                table: "product",
                column: "gradeid");

            migrationBuilder.CreateIndex(
                name: "IX_product_modelid",
                table: "product",
                column: "modelid");

            migrationBuilder.CreateIndex(
                name: "IX_product_productgroupid",
                table: "product",
                column: "productgroupid");

            migrationBuilder.CreateIndex(
                name: "IX_product_sizeid",
                table: "product",
                column: "sizeid");

            migrationBuilder.CreateIndex(
                name: "IX_product_weightid",
                table: "product",
                column: "weightid");

            migrationBuilder.CreateIndex(
                name: "IX_productbarcode_companyid",
                table: "productbarcode",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_productbarcode_productid",
                table: "productbarcode",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_productgroup_companyid",
                table: "productgroup",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_productmembe_companyid",
                table: "productmembe",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_productmembe_customerid",
                table: "productmembe",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_productmembe_productid",
                table: "productmembe",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_productset_companyid",
                table: "productset",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_productsetdetail_companyid",
                table: "productsetdetail",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_productsetdetail_productid",
                table: "productsetdetail",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_productsetdetail_productsetid",
                table: "productsetdetail",
                column: "productsetid");

            migrationBuilder.CreateIndex(
                name: "IX_productunit_companyid",
                table: "productunit",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_productunit_productid",
                table: "productunit",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_project_companyid",
                table: "project",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_bookid",
                table: "receipttrnd",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_branchid",
                table: "receipttrnd",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_companyid",
                table: "receipttrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_contactid",
                table: "receipttrnd",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_currencyid",
                table: "receipttrnd",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_customerid",
                table: "receipttrnd",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_departmentid",
                table: "receipttrnd",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_gltrnhid",
                table: "receipttrnd",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_plansld",
                table: "receipttrnd",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_projectid",
                table: "receipttrnd",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_receipttrnhid",
                table: "receipttrnd",
                column: "receipttrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_salemanid",
                table: "receipttrnd",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_sectionid",
                table: "receipttrnd",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnd_vendorid",
                table: "receipttrnd",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_bookid",
                table: "receipttrnh",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_branchid",
                table: "receipttrnh",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_companyid",
                table: "receipttrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_contactid",
                table: "receipttrnh",
                column: "contactid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_currencyid",
                table: "receipttrnh",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_customerid",
                table: "receipttrnh",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_departmentid",
                table: "receipttrnh",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_gltrnhid",
                table: "receipttrnh",
                column: "gltrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_plansld",
                table: "receipttrnh",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_projectid",
                table: "receipttrnh",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_salemanid",
                table: "receipttrnh",
                column: "salemanid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_sectionid",
                table: "receipttrnh",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnh_vendorid",
                table: "receipttrnh",
                column: "vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_bookid",
                table: "receipttrnref",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_branchid",
                table: "receipttrnref",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_companyid",
                table: "receipttrnref",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_Contactid",
                table: "receipttrnref",
                column: "Contactid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_Currencyid",
                table: "receipttrnref",
                column: "Currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_Customerid",
                table: "receipttrnref",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_departmentid",
                table: "receipttrnref",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_plansld",
                table: "receipttrnref",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_projectid",
                table: "receipttrnref",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_SaleManid",
                table: "receipttrnref",
                column: "SaleManid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_sectionid",
                table: "receipttrnref",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_receipttrnref_Vendorid",
                table: "receipttrnref",
                column: "Vendorid");

            migrationBuilder.CreateIndex(
                name: "IX_salearea_companyid",
                table: "salearea",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_saleman_companyid",
                table: "saleman",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_saleteam_companyid",
                table: "saleteam",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_section_companyid",
                table: "section",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_segmentation_companyid",
                table: "segmentation",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_serial_branchid",
                table: "serial",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_serial_companyid",
                table: "serial",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_serial_productid",
                table: "serial",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_serial_warehouseid",
                table: "serial",
                column: "warehouseid");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_bookid",
                table: "serialtrnh",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_branchid",
                table: "serialtrnh",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_companyid",
                table: "serialtrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_departmentid",
                table: "serialtrnh",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_plansld",
                table: "serialtrnh",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_productid",
                table: "serialtrnh",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_projectid",
                table: "serialtrnh",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_sectionid",
                table: "serialtrnh",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_serialtrnh_warehouseid",
                table: "serialtrnh",
                column: "warehouseid");

            migrationBuilder.CreateIndex(
                name: "IX_service_brandid",
                table: "service",
                column: "brandid");

            migrationBuilder.CreateIndex(
                name: "IX_service_categoryid",
                table: "service",
                column: "categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_service_colorid",
                table: "service",
                column: "colorid");

            migrationBuilder.CreateIndex(
                name: "IX_service_companyid",
                table: "service",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_service_designid",
                table: "service",
                column: "designid");

            migrationBuilder.CreateIndex(
                name: "IX_service_formatid",
                table: "service",
                column: "formatid");

            migrationBuilder.CreateIndex(
                name: "IX_service_gradeid",
                table: "service",
                column: "gradeid");

            migrationBuilder.CreateIndex(
                name: "IX_service_modelid",
                table: "service",
                column: "modelid");

            migrationBuilder.CreateIndex(
                name: "IX_service_productgroupid",
                table: "service",
                column: "productgroupid");

            migrationBuilder.CreateIndex(
                name: "IX_service_sizeid",
                table: "service",
                column: "sizeid");

            migrationBuilder.CreateIndex(
                name: "IX_service_weightid",
                table: "service",
                column: "weightid");

            migrationBuilder.CreateIndex(
                name: "IX_servicemember_companyid",
                table: "servicemember",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_servicemember_customerid",
                table: "servicemember",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_servicemember_serviceid",
                table: "servicemember",
                column: "serviceid");

            migrationBuilder.CreateIndex(
                name: "IX_serviceunit_companyid",
                table: "serviceunit",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_serviceunit_ServiceId",
                table: "serviceunit",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_shelf_companyid",
                table: "shelf",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_shelf_warehouseid",
                table: "shelf",
                column: "warehouseid");

            migrationBuilder.CreateIndex(
                name: "IX_shipping_companyid",
                table: "shipping",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_size_companyid",
                table: "size",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_um_companyid",
                table: "um",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_accreceivableid",
                table: "vendor",
                column: "accreceivableid");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_companyid",
                table: "vendor",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_vendorgroupid",
                table: "vendor",
                column: "vendorgroupid");

            migrationBuilder.CreateIndex(
                name: "IX_vendorgroup_companyid",
                table: "vendorgroup",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_warehouse_branchid",
                table: "warehouse",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_warehouse_companyid",
                table: "warehouse",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_weight_companyid",
                table: "weight",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnd_bookid",
                table: "whtrnd",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnd_branchid",
                table: "whtrnd",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnd_companyid",
                table: "whtrnd",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnd_departmentid",
                table: "whtrnd",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnd_plansld",
                table: "whtrnd",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnd_projectid",
                table: "whtrnd",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnd_sectionid",
                table: "whtrnd",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnd_whtrnhid",
                table: "whtrnd",
                column: "whtrnhid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_bookid",
                table: "whtrnh",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_branchid",
                table: "whtrnh",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_companyid",
                table: "whtrnh",
                column: "companyid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_customerid",
                table: "whtrnh",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_departmentid",
                table: "whtrnh",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_plansld",
                table: "whtrnh",
                column: "plansld");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_projectid",
                table: "whtrnh",
                column: "projectid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_sectionid",
                table: "whtrnh",
                column: "sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_whtrnh_vendorid",
                table: "whtrnh",
                column: "vendorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accrole");

            migrationBuilder.DropTable(
                name: "accroletemplated");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "asset");

            migrationBuilder.DropTable(
                name: "billtrnd");

            migrationBuilder.DropTable(
                name: "billtrnref");

            migrationBuilder.DropTable(
                name: "bilpay");

            migrationBuilder.DropTable(
                name: "bookbank");

            migrationBuilder.DropTable(
                name: "customecredit");

            migrationBuilder.DropTable(
                name: "description");

            migrationBuilder.DropTable(
                name: "doclink");

            migrationBuilder.DropTable(
                name: "doctype");

            migrationBuilder.DropTable(
                name: "erp_log");

            migrationBuilder.DropTable(
                name: "formmaster");

            migrationBuilder.DropTable(
                name: "fromref");

            migrationBuilder.DropTable(
                name: "gltrnd");

            migrationBuilder.DropTable(
                name: "invtrnd");

            migrationBuilder.DropTable(
                name: "logs");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "mop");

            migrationBuilder.DropTable(
                name: "ordertrnd");

            migrationBuilder.DropTable(
                name: "payintrnd");

            migrationBuilder.DropTable(
                name: "paytype");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "postalcountry");

            migrationBuilder.DropTable(
                name: "postaldisrict");

            migrationBuilder.DropTable(
                name: "postalprovince");

            migrationBuilder.DropTable(
                name: "postalsubdisrict");

            migrationBuilder.DropTable(
                name: "prereceipttrnd");

            migrationBuilder.DropTable(
                name: "prereceipttrnref");

            migrationBuilder.DropTable(
                name: "pricelist");

            migrationBuilder.DropTable(
                name: "pricelisttrnd");

            migrationBuilder.DropTable(
                name: "prodtype");

            migrationBuilder.DropTable(
                name: "productbarcode");

            migrationBuilder.DropTable(
                name: "productmembe");

            migrationBuilder.DropTable(
                name: "productsetdetail");

            migrationBuilder.DropTable(
                name: "productshelf");

            migrationBuilder.DropTable(
                name: "productunit");

            migrationBuilder.DropTable(
                name: "receipttrnd");

            migrationBuilder.DropTable(
                name: "receipttrnref");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "rolemenu");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "serial");

            migrationBuilder.DropTable(
                name: "serialtrnh");

            migrationBuilder.DropTable(
                name: "servicemember");

            migrationBuilder.DropTable(
                name: "serviceunit");

            migrationBuilder.DropTable(
                name: "shelf");

            migrationBuilder.DropTable(
                name: "shipping");

            migrationBuilder.DropTable(
                name: "storageimage");

            migrationBuilder.DropTable(
                name: "sysoption");

            migrationBuilder.DropTable(
                name: "um");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "vattype");

            migrationBuilder.DropTable(
                name: "warehousetype");

            migrationBuilder.DropTable(
                name: "whtrnd");

            migrationBuilder.DropTable(
                name: "assetgroup");

            migrationBuilder.DropTable(
                name: "billtrnh");

            migrationBuilder.DropTable(
                name: "invtrnh");

            migrationBuilder.DropTable(
                name: "ordertrnh");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "prereceipttrnh");

            migrationBuilder.DropTable(
                name: "pricelisttrnh");

            migrationBuilder.DropTable(
                name: "productset");

            migrationBuilder.DropTable(
                name: "receipttrnh");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "service");

            migrationBuilder.DropTable(
                name: "warehouse");

            migrationBuilder.DropTable(
                name: "whtrnh");

            migrationBuilder.DropTable(
                name: "bankbranch");

            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "currency");

            migrationBuilder.DropTable(
                name: "gltrnh");

            migrationBuilder.DropTable(
                name: "brand");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "design");

            migrationBuilder.DropTable(
                name: "format");

            migrationBuilder.DropTable(
                name: "grade");

            migrationBuilder.DropTable(
                name: "model");

            migrationBuilder.DropTable(
                name: "productgroup");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "weight");

            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "vendor");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "plans");

            migrationBuilder.DropTable(
                name: "project");

            migrationBuilder.DropTable(
                name: "accbook");

            migrationBuilder.DropTable(
                name: "accroletemplateh");

            migrationBuilder.DropTable(
                name: "branch");

            migrationBuilder.DropTable(
                name: "bank");

            migrationBuilder.DropTable(
                name: "custgroup");

            migrationBuilder.DropTable(
                name: "membergroup");

            migrationBuilder.DropTable(
                name: "salearea");

            migrationBuilder.DropTable(
                name: "saleman");

            migrationBuilder.DropTable(
                name: "saleteam");

            migrationBuilder.DropTable(
                name: "segmentation");

            migrationBuilder.DropTable(
                name: "vendorgroup");

            migrationBuilder.DropTable(
                name: "section");

            migrationBuilder.DropTable(
                name: "acchart");

            migrationBuilder.DropTable(
                name: "company");
        }
    }
}
