using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace alKafi.Models
{
    public partial class alkafidb2019Context : DbContext
    {
        public alkafidb2019Context()
        {
        }

        public alkafidb2019Context(DbContextOptions<alkafidb2019Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AbsenceTbl> AbsenceTbls { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountVw> AccountVws { get; set; }
        public virtual DbSet<AccountsView> AccountsViews { get; set; }
        public virtual DbSet<AirplaneTbl> AirplaneTbls { get; set; }
        public virtual DbSet<AirportTbl> AirportTbls { get; set; }
        public virtual DbSet<AqedApproveVw> AqedApproveVws { get; set; }
        public virtual DbSet<AqedConditionsTbl> AqedConditionsTbls { get; set; }
        public virtual DbSet<AqedCondtionTbl> AqedCondtionTbls { get; set; }
        public virtual DbSet<AqedCvTawkeelVw> AqedCvTawkeelVws { get; set; }
        public virtual DbSet<AqedExitTajeerTbl> AqedExitTajeerTbls { get; set; }
        public virtual DbSet<AqedExpeerTbl> AqedExpeerTbls { get; set; }
        public virtual DbSet<AqedHasemTbl> AqedHasemTbls { get; set; }
        public virtual DbSet<AqedMoney> AqedMoneys { get; set; }
        public virtual DbSet<AqedNotesTajeerTbl> AqedNotesTajeerTbls { get; set; }
        public virtual DbSet<AqedNotesTbl> AqedNotesTbls { get; set; }
        public virtual DbSet<AqedNotesVw> AqedNotesVws { get; set; }
        public virtual DbSet<AqedReportSetting> AqedReportSettings { get; set; }
        public virtual DbSet<AqedSearchview> AqedSearchviews { get; set; }
        public virtual DbSet<AqedServiceView> AqedServiceViews { get; set; }
        public virtual DbSet<AqedSourceTbl> AqedSourceTbls { get; set; }
        public virtual DbSet<AqedStautsVw> AqedStautsVws { get; set; }
        public virtual DbSet<AqedT3jeerView> AqedT3jeerViews { get; set; }
        public virtual DbSet<AqedTa3jeerTbl> AqedTa3jeerTbls { get; set; }
        public virtual DbSet<AqedTajeerTransferTbl> AqedTajeerTransferTbls { get; set; }
        public virtual DbSet<AqedTbl> AqedTbls { get; set; }
        public virtual DbSet<AqedView> AqedViews { get; set; }
        public virtual DbSet<AqerdPrintView> AqerdPrintViews { get; set; }
        public virtual DbSet<Arrival> Arrivals { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AttachmentAllTbl> AttachmentAllTbls { get; set; }
        public virtual DbSet<AttachmentTbl> AttachmentTbls { get; set; }
        public virtual DbSet<AttachmentType> AttachmentTypes { get; set; }
        public virtual DbSet<BalanceSheetView> BalanceSheetViews { get; set; }
        public virtual DbSet<BeforeaqedTbl> BeforeaqedTbls { get; set; }
        public virtual DbSet<Benefit> Benefits { get; set; }
        public virtual DbSet<BillAccHdview> BillAccHdviews { get; set; }
        public virtual DbSet<BillAccView> BillAccViews { get; set; }
        public virtual DbSet<BillHeaderView> BillHeaderViews { get; set; }
        public virtual DbSet<BillInView> BillInViews { get; set; }
        public virtual DbSet<BillOutView> BillOutViews { get; set; }
        public virtual DbSet<ConditionsTbl> ConditionsTbls { get; set; }
        public virtual DbSet<CustPricesTbl> CustPricesTbls { get; set; }
        public virtual DbSet<CustomerOrdersview> CustomerOrdersviews { get; set; }
        public virtual DbSet<CustomerTbl> CustomerTbls { get; set; }
        public virtual DbSet<CvView> CvViews { get; set; }
        public virtual DbSet<DataView> DataViews { get; set; }
        public virtual DbSet<DateMonth> DateMonths { get; set; }
        public virtual DbSet<EmpAutoAttendance> EmpAutoAttendances { get; set; }
        public virtual DbSet<EmpBenefit> EmpBenefits { get; set; }
        public virtual DbSet<EmployeeContract> EmployeeContracts { get; set; }
        public virtual DbSet<EmployeeTbl> EmployeeTbls { get; set; }
        public virtual DbSet<EmployerinformationrequestVw> EmployerinformationrequestVws { get; set; }
        public virtual DbSet<FaturaTbl> FaturaTbls { get; set; }
        public virtual DbSet<FillipoReportSitting> FillipoReportSittings { get; set; }
        public virtual DbSet<GehatAlqodomTbl> GehatAlqodomTbls { get; set; }
        public virtual DbSet<GeneralSalesTbl> GeneralSalesTbls { get; set; }
        public virtual DbSet<HasamView> HasamViews { get; set; }
        public virtual DbSet<IncomeTbl> IncomeTbls { get; set; }
        public virtual DbSet<Incometype> Incometypes { get; set; }
        public virtual DbSet<InternalMsgTbl> InternalMsgTbls { get; set; }
        public virtual DbSet<JobTbl> JobTbls { get; set; }
        public virtual DbSet<KafalView> KafalViews { get; set; }
        public virtual DbSet<KafalaMoney> KafalaMoneys { get; set; }
        public virtual DbSet<KafalaReportVw> KafalaReportVws { get; set; }
        public virtual DbSet<KafalaTbl> KafalaTbls { get; set; }
        public virtual DbSet<KafalaView> KafalaViews { get; set; }
        public virtual DbSet<LogTbl> LogTbls { get; set; }
        public virtual DbSet<MadyonaView> MadyonaViews { get; set; }
        public virtual DbSet<MainBillInfo> MainBillInfos { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Mo3amalatDa3raVw> Mo3amalatDa3raVws { get; set; }
        public virtual DbSet<MonthlySalary> MonthlySalaries { get; set; }
        public virtual DbSet<MouqebMoney> MouqebMoneys { get; set; }
        public virtual DbSet<Mouqebviewmoney> Mouqebviewmoneys { get; set; }
        public virtual DbSet<Muaqeb> Muaqebs { get; set; }
        public virtual DbSet<Muaqebmonyview> Muaqebmonyviews { get; set; }
        public virtual DbSet<NationalityTbl> NationalityTbls { get; set; }
        public virtual DbSet<OfficeDiscountPayment> OfficeDiscountPayments { get; set; }
        public virtual DbSet<OfficeInfo> OfficeInfos { get; set; }
        public virtual DbSet<OfficeMoneyTbl> OfficeMoneyTbls { get; set; }
        public virtual DbSet<OfficePayment> OfficePayments { get; set; }
        public virtual DbSet<OfficeRequirmentVw> OfficeRequirmentVws { get; set; }
        public virtual DbSet<OfficeTbl> OfficeTbls { get; set; }
        public virtual DbSet<Officemoneyview> Officemoneyviews { get; set; }
        public virtual DbSet<OfficerequirmentTbl> OfficerequirmentTbls { get; set; }
        public virtual DbSet<OtherServicesTbl> OtherServicesTbls { get; set; }
        public virtual DbSet<PayedName> PayedNames { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PredefindeReport> PredefindeReports { get; set; }
        public virtual DbSet<RecStatusArrivel> RecStatusArrivels { get; set; }
        public virtual DbSet<RecStatusMsgVw> RecStatusMsgVws { get; set; }
        public virtual DbSet<RecStatusUpVw> RecStatusUpVws { get; set; }
        public virtual DbSet<RecView> RecViews { get; set; }
        public virtual DbSet<Receiptpaymentview> Receiptpaymentviews { get; set; }
        public virtual DbSet<RecruitmenterStatusVw> RecruitmenterStatusVws { get; set; }
        public virtual DbSet<RecruitmenterTa3jeerTbl> RecruitmenterTa3jeerTbls { get; set; }
        public virtual DbSet<RecruitmenterTbl> RecruitmenterTbls { get; set; }
        public virtual DbSet<RelegionTbl> RelegionTbls { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReturnReplaceView> ReturnReplaceViews { get; set; }
        public virtual DbSet<SanadPrintSetting> SanadPrintSettings { get; set; }
        public virtual DbSet<SearchStView> SearchStViews { get; set; }
        public virtual DbSet<ServicesTypesTbl> ServicesTypesTbls { get; set; }
        public virtual DbSet<SmsSendVw> SmsSendVws { get; set; }
        public virtual DbSet<SolafPaymentTbl> SolafPaymentTbls { get; set; }
        public virtual DbSet<SolafTbl> SolafTbls { get; set; }
        public virtual DbSet<SrvServicesTbl> SrvServicesTbls { get; set; }
        public virtual DbSet<StatusNameTbl> StatusNameTbls { get; set; }
        public virtual DbSet<StatusTbl> StatusTbls { get; set; }
        public virtual DbSet<StatusView> StatusViews { get; set; }
        public virtual DbSet<TableMap> TableMaps { get; set; }
        public virtual DbSet<TajeerkafalaVw> TajeerkafalaVws { get; set; }
        public virtual DbSet<TaxToTview> TaxToTviews { get; set; }
        public virtual DbSet<Taxview> Taxviews { get; set; }
        public virtual DbSet<Tblabout> Tblabouts { get; set; }
        public virtual DbSet<Tblacount> Tblacounts { get; set; }
        public virtual DbSet<Tblanlay> Tblanlays { get; set; }
        public virtual DbSet<TblappWin> TblappWins { get; set; }
        public virtual DbSet<TblbillAcc> TblbillAccs { get; set; }
        public virtual DbSet<TblbillAccHd> TblbillAccHds { get; set; }
        public virtual DbSet<TblbillHeader> TblbillHeaders { get; set; }
        public virtual DbSet<TblbillsIn> TblbillsIns { get; set; }
        public virtual DbSet<TblbillsOut> TblbillsOuts { get; set; }
        public virtual DbSet<Tblcompany> Tblcompanies { get; set; }
        public virtual DbSet<Tblconu> Tblconus { get; set; }
        public virtual DbSet<TblcostCenter> TblcostCenters { get; set; }
        public virtual DbSet<Tblcurrncey> Tblcurrnceys { get; set; }
        public virtual DbSet<TblcusInformation> TblcusInformations { get; set; }
        public virtual DbSet<Tblendacount> Tblendacounts { get; set; }
        public virtual DbSet<Tblfooter> Tblfooters { get; set; }
        public virtual DbSet<Tblgetprice> Tblgetprices { get; set; }
        public virtual DbSet<Tblinvoice> Tblinvoices { get; set; }
        public virtual DbSet<TblmainBill> TblmainBills { get; set; }
        public virtual DbSet<Tblmessege> Tblmesseges { get; set; }
        public virtual DbSet<TblourWork> TblourWorks { get; set; }
        public virtual DbSet<Tblpartner> Tblpartners { get; set; }
        public virtual DbSet<Tblsay> Tblsays { get; set; }
        public virtual DbSet<Tblservice> Tblservices { get; set; }
        public virtual DbSet<TblshowWrk> TblshowWrks { get; set; }
        public virtual DbSet<Tblsioweb> Tblsiowebs { get; set; }
        public virtual DbSet<Tblslider> Tblsliders { get; set; }
        public virtual DbSet<TblusersMail> TblusersMails { get; set; }
        public virtual DbSet<Tblweb> Tblwebs { get; set; }
        public virtual DbSet<TeacherView> TeacherViews { get; set; }
        public virtual DbSet<TfweedMasareefTbl> TfweedMasareefTbls { get; set; }
        public virtual DbSet<TfweedMoney> TfweedMoneys { get; set; }
        public virtual DbSet<TfweedTbl> TfweedTbls { get; set; }
        public virtual DbSet<TransMadyonaView> TransMadyonaViews { get; set; }
        public virtual DbSet<TransationTbl> TransationTbls { get; set; }
        public virtual DbSet<TransferAccount> TransferAccounts { get; set; }
        public virtual DbSet<TransmittTbl> TransmittTbls { get; set; }
        public virtual DbSet<TransmittalVw> TransmittalVws { get; set; }
        public virtual DbSet<TranstionVw> TranstionVws { get; set; }
        public virtual DbSet<TrialBalanceView> TrialBalanceViews { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<UserTbl> UserTbls { get; set; }
        public virtual DbSet<WebShow> WebShows { get; set; }
        public virtual DbSet<Year> Years { get; set; }
        public virtual DbSet<YearView> YearViews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SARA;Database=alkafidb2019;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AbsenceTbl>(entity =>
            {
                entity.ToTable("absence_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbsenceFromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("absence_from_date");

                entity.Property(e => e.AbsenceToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("absence_to_date");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.AbsenceTbls)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_absence_tbl_employee_tbl");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("account_name");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notice)
                    .HasMaxLength(500)
                    .HasColumnName("notice");
            });

            modelBuilder.Entity<AccountVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Account_vw");

                entity.Property(e => e.AccountId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("account_name");

                entity.Property(e => e.Notice)
                    .HasMaxLength(500)
                    .HasColumnName("notice");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<AccountsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountsView");

                entity.Property(e => e.AccountCode).HasMaxLength(150);

                entity.Property(e => e.AccountMd).HasColumnName("AccountMD");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AcountName).HasMaxLength(250);

                entity.Property(e => e.Endid).HasColumnName("ENDID");

                entity.Property(e => e.Endname)
                    .HasMaxLength(50)
                    .HasColumnName("ENDName");

                entity.Property(e => e.MainId).HasColumnName("MainID");

                entity.Property(e => e.MainName).HasMaxLength(250);
            });

            modelBuilder.Entity<AirplaneTbl>(entity =>
            {
                entity.ToTable("airplane_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AirName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("air_name");
            });

            modelBuilder.Entity<AirportTbl>(entity =>
            {
                entity.ToTable("airport_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Airport)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("airport");

                entity.Property(e => e.AirportEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("airport_en");
            });

            modelBuilder.Entity<AqedApproveVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Aqed_approve_vw");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.SevenCond).HasColumnName("seven_cond");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<AqedConditionsTbl>(entity =>
            {
                entity.ToTable("aqed_conditions_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedConditionId).HasColumnName("aqed_condition_id");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.IsChoose).HasColumnName("is_choose");
            });

            modelBuilder.Entity<AqedCondtionTbl>(entity =>
            {
                entity.ToTable("aqed_Condtion_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedTxt).HasColumnName("aqed_TXT");
            });

            modelBuilder.Entity<AqedCvTawkeelVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("aqed_cv_tawkeel_vw");

                entity.Property(e => e.AdressAr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("adress_ar");

                entity.Property(e => e.AdressEn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("adress_en");

                entity.Property(e => e.AqarebAddress)
                    .HasMaxLength(500)
                    .HasColumnName("aqarebAddress");

                entity.Property(e => e.AqarebAddressAr)
                    .HasMaxLength(500)
                    .HasColumnName("aqarebAddress_ar");

                entity.Property(e => e.AqarebselaAr)
                    .HasMaxLength(150)
                    .HasColumnName("aqarebsela_ar");

                entity.Property(e => e.AqarebselaEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("aqarebsela_en");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("bankaccount");

                entity.Property(e => e.BankaddressAr)
                    .HasMaxLength(550)
                    .HasColumnName("bankaddress_ar");

                entity.Property(e => e.BankaddressEn)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("bankaddress_en");

                entity.Property(e => e.BanknameAr)
                    .HasMaxLength(500)
                    .HasColumnName("bankname_ar");

                entity.Property(e => e.BanknameEn)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bankname_en");

                entity.Property(e => e.Custemail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("custemail");

                entity.Property(e => e.HomePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("home_phone");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idnum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("idnum");

                entity.Property(e => e.LNameAr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("l_name_ar");

                entity.Property(e => e.LNameEn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("l_name_en");

                entity.Property(e => e.MhnaAr)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("mhna_ar");

                entity.Property(e => e.MhnaEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mhna_en");

                entity.Property(e => e.MydistAr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mydist_ar");

                entity.Property(e => e.MydistEn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("mydist_en");

                entity.Property(e => e.Myemail)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("myemail");

                entity.Property(e => e.MyoriginAr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("myorigin_ar");

                entity.Property(e => e.MyoriginEn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("myorigin_en");

                entity.Property(e => e.MystreatAr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("mystreat_ar");

                entity.Property(e => e.MystreatEn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("mystreat_en");

                entity.Property(e => e.Mytarkhees)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("mytarkhees");

                entity.Property(e => e.Nameofaqareb)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nameofaqareb");

                entity.Property(e => e.NameofaqarebAr)
                    .HasMaxLength(250)
                    .HasColumnName("nameofaqareb_ar");

                entity.Property(e => e.Numberofaqareb)
                    .HasMaxLength(50)
                    .HasColumnName("numberofaqareb");

                entity.Property(e => e.OfficeAddress)
                    .IsRequired()
                    .HasMaxLength(1152)
                    .IsUnicode(false)
                    .HasColumnName("office_address");

                entity.Property(e => e.OfficeAddressAr)
                    .IsRequired()
                    .HasMaxLength(452)
                    .HasColumnName("office_address_ar");

                entity.Property(e => e.OfficeDist)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("office_dist");

                entity.Property(e => e.OfficeDistAr)
                    .HasMaxLength(150)
                    .HasColumnName("office_dist_ar");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("office_name");

                entity.Property(e => e.OfficeNameAr)
                    .HasMaxLength(150)
                    .HasColumnName("office_name_ar");

                entity.Property(e => e.OfficePhones)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("office_phones");

                entity.Property(e => e.OfficeStreatAr)
                    .HasMaxLength(150)
                    .HasColumnName("office_streat_ar");

                entity.Property(e => e.OfficeStreatEn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("office_streat_en");

                entity.Property(e => e.OfficeTblId).HasColumnName("office_tblID");

                entity.Property(e => e.Officeemail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("officeemail");

                entity.Property(e => e.Officetarkhees)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("officetarkhees");

                entity.Property(e => e.OwnerAddressAr)
                    .HasMaxLength(350)
                    .HasColumnName("owner_address_ar");

                entity.Property(e => e.OwnerAddressEn)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("owner_address_en");

                entity.Property(e => e.OwnerAge).HasColumnName("owner_age");

                entity.Property(e => e.OwnerAr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("owner_ar");

                entity.Property(e => e.OwnerChildNum).HasColumnName("owner_child_num");

                entity.Property(e => e.OwnerEn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("owner_en");

                entity.Property(e => e.OwnerFax)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("owner_fax");

                entity.Property(e => e.OwnerFone)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("owner_fone");

                entity.Property(e => e.OwnerMadinaAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_madina_ar");

                entity.Property(e => e.OwnerMadinaEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("owner_madina_en");

                entity.Property(e => e.OwnerMob)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("owner_mob");

                entity.Property(e => e.OwnerPox)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("owner_pox");

                entity.Property(e => e.OwnerReginAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_regin_ar");

                entity.Property(e => e.OwnerReginEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("owner_regin_en");

                entity.Property(e => e.OwnerSefaAr)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("owner_sefa_ar");

                entity.Property(e => e.OwnerSefaEn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("owner_sefa_en");

                entity.Property(e => e.OwnerStatusAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_status_ar");

                entity.Property(e => e.OwnerStatusEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("owner_status_en");

                entity.Property(e => e.OwnerStreetAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_street_ar");

                entity.Property(e => e.OwnerStreetEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("owner_street_en");

                entity.Property(e => e.OwnernameAr)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ownername_ar");

                entity.Property(e => e.OwnernameEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ownername_en");

                entity.Property(e => e.Passportedate)
                    .HasColumnType("date")
                    .HasColumnName("passportedate");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.Passportplace)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("passportplace");

                entity.Property(e => e.PassportplaceAr)
                    .HasMaxLength(250)
                    .HasColumnName("passportplace_ar");

                entity.Property(e => e.Passportsdate)
                    .HasColumnType("date")
                    .HasColumnName("passportsdate");

                entity.Property(e => e.RecAddressAr)
                    .HasMaxLength(500)
                    .HasColumnName("rec_address_ar");

                entity.Property(e => e.RecAddressInFilp)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("rec_address_in_filp");

                entity.Property(e => e.RecMobiile)
                    .HasMaxLength(50)
                    .HasColumnName("rec_mobiile");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.RecNameAr)
                    .HasMaxLength(250)
                    .HasColumnName("rec_name_ar");

                entity.Property(e => e.RecSalary)
                    .HasMaxLength(20)
                    .HasColumnName("rec_salary");

                entity.Property(e => e.RecStatusAr)
                    .HasMaxLength(250)
                    .HasColumnName("rec_status_ar");

                entity.Property(e => e.RecStatusEn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("rec_status_en");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<AqedExitTajeerTbl>(entity =>
            {
                entity.ToTable("aqed_exit_tajeer_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArrType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("arr_type");

                entity.Property(e => e.IsOut).HasColumnName("is_out");

                entity.Property(e => e.NoteChk).HasColumnName("NoteCHK");

                entity.Property(e => e.NoteDate)
                    .HasColumnType("date")
                    .HasColumnName("note_date");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Rec)
                    .WithMany(p => p.AqedExitTajeerTbls)
                    .HasForeignKey(d => d.RecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_exit_tbl_aqed_tbl_tajeer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AqedExitTajeerTbls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_exit_tajeer_tbl_user_tbl");
            });

            modelBuilder.Entity<AqedExpeerTbl>(entity =>
            {
                entity.ToTable("aqed_Expeer_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedTxt).HasColumnName("aqed_TXT");
            });

            modelBuilder.Entity<AqedHasemTbl>(entity =>
            {
                entity.ToTable("aqed_hasem_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.HAmount).HasColumnName("h_amount");

                entity.Property(e => e.HDate)
                    .HasColumnType("date")
                    .HasColumnName("h_date");

                entity.Property(e => e.HNotes).HasColumnName("h_notes");

                entity.Property(e => e.HType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("h_type");

                entity.Property(e => e.HUser).HasColumnName("h_user");

                entity.HasOne(d => d.Aqed)
                    .WithMany(p => p.AqedHasemTbls)
                    .HasForeignKey(d => d.AqedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_hasem_tbl_aqed_tbl");

                entity.HasOne(d => d.HUserNavigation)
                    .WithMany(p => p.AqedHasemTbls)
                    .HasForeignKey(d => d.HUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_hasem_tbl_user_tbl");
            });

            modelBuilder.Entity<AqedMoney>(entity =>
            {
                entity.ToTable("aqed_money");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.IsSafara).HasColumnName("is_safara");

                entity.Property(e => e.MDate)
                    .HasColumnType("date")
                    .HasColumnName("m_date");

                entity.Property(e => e.MName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("m_name");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .HasColumnName("notes");

                entity.Property(e => e.PayNotes)
                    .HasMaxLength(300)
                    .HasColumnName("pay_notes");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AqedMoneys)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_money_account");

                entity.HasOne(d => d.Aqed)
                    .WithMany(p => p.AqedMoneys)
                    .HasForeignKey(d => d.AqedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_money_aqed_tbl");
            });

            modelBuilder.Entity<AqedNotesTajeerTbl>(entity =>
            {
                entity.ToTable("aqed_notes_tajeer_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.NoteChk).HasColumnName("NoteCHK");

                entity.Property(e => e.NoteDate)
                    .HasColumnType("date")
                    .HasColumnName("note_date");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Aqed)
                    .WithMany(p => p.AqedNotesTajeerTbls)
                    .HasForeignKey(d => d.AqedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_notes_tbl_aqed_tbl_tajeer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AqedNotesTajeerTbls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_notes_tajeer_tbl_user_tbl");
            });

            modelBuilder.Entity<AqedNotesTbl>(entity =>
            {
                entity.ToTable("aqed_notes_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.NoteChk).HasColumnName("NoteCHK");

                entity.Property(e => e.NoteDate)
                    .HasColumnType("date")
                    .HasColumnName("note_date");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Aqed)
                    .WithMany(p => p.AqedNotesTbls)
                    .HasForeignKey(d => d.AqedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_notes_tbl_aqed_tbl");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AqedNotesTbls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_notes_tbl_user_tbl");
            });

            modelBuilder.Entity<AqedNotesVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("aqed_notes_vw");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NotceId).HasColumnName("NotceID");

                entity.Property(e => e.NoteChk).HasColumnName("NoteCHK");

                entity.Property(e => e.NoteDate)
                    .HasColumnType("date")
                    .HasColumnName("note_date");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<AqedReportSetting>(entity =>
            {
                entity.ToTable("aqed_report_settings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FieldBind)
                    .HasMaxLength(100)
                    .HasColumnName("field_bind");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("field_name");

                entity.Property(e => e.Hight)
                    .HasColumnName("hight")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Xc)
                    .HasColumnName("xc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Yc)
                    .HasColumnName("yc")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AqedSearchview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("aqed_searchview");

                entity.Property(e => e.AgeFrom).HasColumnName("age_from");

                entity.Property(e => e.AgeTo).HasColumnName("age_to");

                entity.Property(e => e.AirportId).HasColumnName("airport_id");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedDateH)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("aqed_date_h");

                entity.Property(e => e.AqedFrom)
                    .HasColumnType("date")
                    .HasColumnName("aqed_from");

                entity.Property(e => e.AqedPeriod).HasColumnName("aqed_period");

                entity.Property(e => e.AqedSource).HasColumnName("aqed_source");

                entity.Property(e => e.AqedTo)
                    .HasColumnType("date")
                    .HasColumnName("aqed_to");

                entity.Property(e => e.BillDeleteId).HasColumnName("BillDeleteID");

                entity.Property(e => e.BillMainId).HasColumnName("BillMainID");

                entity.Property(e => e.BillRecId).HasColumnName("BillRecID");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.ChvisaDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chvisa_date");

                entity.Property(e => e.Ckarrivel).HasColumnName("CKArrivel");

                entity.Property(e => e.Ckstat).HasColumnName("CKStat");

                entity.Property(e => e.Ckticket).HasColumnName("CKTicket");

                entity.Property(e => e.CkticketDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CKTicket_date");

                entity.Property(e => e.Ckvisa).HasColumnName("CKVisa");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.CostId).HasColumnName("CostID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("country_name");

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.CusAccId).HasColumnName("CusAccID");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.DateDelete)
                    .HasColumnType("date")
                    .HasColumnName("date_delete");

                entity.Property(e => e.DisCountVl).HasColumnName("DisCountVL");

                entity.Property(e => e.Dm)
                    .HasMaxLength(50)
                    .HasColumnName("dm");

                entity.Property(e => e.EightCond).HasColumnName("eight_cond");

                entity.Property(e => e.FourteenCond)
                    .HasMaxLength(4000)
                    .HasColumnName("fourteen_cond");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdDateofbirth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_dateofbirth");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.Idd)
                    .HasMaxLength(50)
                    .HasColumnName("idd");

                entity.Property(e => e.IjazaNum).HasColumnName("ijaza_num");

                entity.Property(e => e.IsAqed).HasColumnName("is_aqed");

                entity.Property(e => e.IsDefined).HasColumnName("is_defined");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsNone).HasColumnName("is_none");

                entity.Property(e => e.IsPayedForVisa).HasColumnName("is_payed_for_visa");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.IsSpeed).HasColumnName("is_speed");

                entity.Property(e => e.IsVip).HasColumnName("is_vip");

                entity.Property(e => e.IsWakeel).HasColumnName("is_wakeel");

                entity.Property(e => e.Isarrive).HasColumnName("isarrive");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.JobEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("job_en");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Mad)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("mad");

                entity.Property(e => e.MuaqebName)
                    .HasMaxLength(50)
                    .HasColumnName("muaqeb_name");

                entity.Property(e => e.MuaqpId).HasColumnName("muaqp_id");

                entity.Property(e => e.MuaqpMoney).HasColumnName("muaqp_money");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.Officename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("officename");

                entity.Property(e => e.Officereq)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("officereq");

                entity.Property(e => e.OfficerequirmentId).HasColumnName("officerequirmentID");

                entity.Property(e => e.OutsidemouqebId).HasColumnName("outsidemouqeb_id");

                entity.Property(e => e.OutsidemouqebMoney)
                    .HasColumnType("money")
                    .HasColumnName("outsidemouqeb_money");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Pt)
                    .HasMaxLength(50)
                    .HasColumnName("pt");

                entity.Property(e => e.Pw)
                    .HasMaxLength(50)
                    .HasColumnName("pw");

                entity.Property(e => e.RecCount).HasColumnName("rec_count");

                entity.Property(e => e.RecName)
                    .HasMaxLength(4000)
                    .HasColumnName("rec_name");

                entity.Property(e => e.ReleginId).HasColumnName("relegin_id");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.SevenCond).HasColumnName("seven_cond");

                entity.Property(e => e.TaakherAmount)
                    .HasColumnType("money")
                    .HasColumnName("taakher_amount");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.UserDelete).HasColumnName("user_delete");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserId1).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.VisaIsOur).HasColumnName("visa_is_our");

                entity.Property(e => e.VisaMoney)
                    .HasColumnType("money")
                    .HasColumnName("visa_money");

                entity.Property(e => e.VisaSource)
                    .HasMaxLength(100)
                    .HasColumnName("visa_source");

                entity.Property(e => e.Visadate)
                    .HasColumnType("date")
                    .HasColumnName("visadate");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");

                entity.Property(e => e.Wakeelname)
                    .HasMaxLength(150)
                    .HasColumnName("wakeelname");

                entity.Property(e => e.YearId).HasColumnName("year_id");

                entity.Property(e => e.YearIdRet).HasColumnName("year_id_ret");
            });

            modelBuilder.Entity<AqedServiceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Aqed_service_View");

                entity.Property(e => e.BillCostId).HasColumnName("BillCostID");

                entity.Property(e => e.BillCurnceyId).HasColumnName("BillCurnceyID");

                entity.Property(e => e.BillMainId).HasColumnName("BillMainID");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Firstmoqeb)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstmoqeb");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsEndDate)
                    .HasColumnType("date")
                    .HasColumnName("is_end_date");

                entity.Property(e => e.IsNew).HasColumnName("is_new");

                entity.Property(e => e.IsNewDate)
                    .HasColumnType("date")
                    .HasColumnName("is_new_date");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.IsSendDate)
                    .HasColumnType("date")
                    .HasColumnName("is_send_date");

                entity.Property(e => e.IsSendToMouqeb).HasColumnName("is_send_to_mouqeb");

                entity.Property(e => e.IsUnderProcess).HasColumnName("is_under_process");

                entity.Property(e => e.IsUnderProcessDate)
                    .HasColumnType("date")
                    .HasColumnName("is_under_process_date");

                entity.Property(e => e.Mad)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("mad");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(12)
                    .HasColumnName("rec_status");

                entity.Property(e => e.RecStatusDate)
                    .HasColumnType("date")
                    .HasColumnName("rec_status_date");

                entity.Property(e => e.Remaindays).HasColumnName("remaindays");

                entity.Property(e => e.Secondmoqeb)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("secondmoqeb");

                entity.Property(e => e.SrvAmount)
                    .HasColumnType("money")
                    .HasColumnName("srv_amount");

                entity.Property(e => e.SrvDate)
                    .HasColumnType("date")
                    .HasColumnName("srv_date");

                entity.Property(e => e.SrvDuration).HasColumnName("srv_duration");

                entity.Property(e => e.SrvMouqeb1).HasColumnName("srv_mouqeb1");

                entity.Property(e => e.SrvMouqeb2).HasColumnName("srv_mouqeb2");

                entity.Property(e => e.SrvMouqebPrice)
                    .HasColumnType("money")
                    .HasColumnName("srv_mouqeb_price");

                entity.Property(e => e.SrvMouqebPrice2)
                    .HasColumnType("money")
                    .HasColumnName("srv_mouqeb_price2");

                entity.Property(e => e.SvrDiscription).HasColumnName("svr_discription");

                entity.Property(e => e.Usrname).HasColumnName("usrname");
            });

            modelBuilder.Entity<AqedSourceTbl>(entity =>
            {
                entity.ToTable("aqed_source_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OfficeSource)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("office_source");
            });

            modelBuilder.Entity<AqedStautsVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("aqed_stauts_vw");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedFrom)
                    .HasColumnType("date")
                    .HasColumnName("aqed_from");

                entity.Property(e => e.AqedTo)
                    .HasColumnType("date")
                    .HasColumnName("aqed_to");

                entity.Property(e => e.Aqedmoney)
                    .HasColumnType("money")
                    .HasColumnName("aqedmoney");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.FromBegin).HasColumnName("from_begin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsNone).HasColumnName("is_none");

                entity.Property(e => e.IsVip).HasColumnName("is_vip");

                entity.Property(e => e.Mouqebmoney)
                    .HasColumnType("money")
                    .HasColumnName("mouqebmoney");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.Numrec).HasColumnName("numrec");

                entity.Property(e => e.Officename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("officename");

                entity.Property(e => e.Officesend)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("officesend");

                entity.Property(e => e.Paymentmony)
                    .HasColumnType("money")
                    .HasColumnName("paymentmony");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.RecRes).HasColumnName("rec_res");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.ToEnd).HasColumnName("to_end");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TotalPeriod).HasColumnName("total_period");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<AqedT3jeerView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Aqed_T3jeer_View");

                entity.Property(e => e.Address)
                    .HasMaxLength(350)
                    .HasColumnName("address");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedFrom)
                    .HasColumnType("date")
                    .HasColumnName("aqed_from");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.AqedSourceId).HasColumnName("aqed_source_id");

                entity.Property(e => e.AqedTo)
                    .HasColumnType("date")
                    .HasColumnName("aqed_to");

                entity.Property(e => e.CMobi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("c_mobi");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.HomePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("home_phone");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDateofbirth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_dateofbirth");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IltzamatTarafOne1).HasColumnName("iltzamat_taraf_one1");

                entity.Property(e => e.IltzamatTarafOne2).HasColumnName("iltzamat_taraf_one2");

                entity.Property(e => e.IltzamatTarafTwo1).HasColumnName("iltzamat_taraf_two1");

                entity.Property(e => e.IltzamatTarafTwo2).HasColumnName("iltzamat_taraf_two2");

                entity.Property(e => e.IqamaNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("iqama_num");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsWakeel).HasColumnName("is_wakeel");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.KafalaMoney)
                    .HasColumnType("money")
                    .HasColumnName("kafala_money");

                entity.Property(e => e.KhedmaPeriod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("khedma_period");

                entity.Property(e => e.Mo3hlatkhbrat)
                    .HasMaxLength(250)
                    .HasColumnName("mo3hlatkhbrat");

                entity.Property(e => e.MonthTklofa)
                    .HasColumnType("money")
                    .HasColumnName("month_tklofa");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nationality");

                entity.Property(e => e.OtherPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("other_phone");

                entity.Property(e => e.OwnerAddressAr)
                    .HasMaxLength(350)
                    .HasColumnName("owner_address_ar");

                entity.Property(e => e.Postmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("postmail");

                entity.Property(e => e.Pox)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pox");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(9)
                    .HasColumnName("rec_status");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.SaatAmal).HasColumnName("saat_amal");

                entity.Property(e => e.SalaryAfterKafala)
                    .HasColumnType("money")
                    .HasColumnName("salary_after_kafala");

                entity.Property(e => e.StartHour).HasColumnName("start_hour");

                entity.Property(e => e.Usrname).HasColumnName("usrname");

                entity.Property(e => e.WakeelName)
                    .HasMaxLength(80)
                    .HasColumnName("wakeel_name");
            });

            modelBuilder.Entity<AqedTa3jeerTbl>(entity =>
            {
                entity.ToTable("aqed_ta3jeer_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedFrom)
                    .HasColumnType("date")
                    .HasColumnName("aqed_from");

                entity.Property(e => e.AqedSourceId).HasColumnName("aqed_source_id");

                entity.Property(e => e.AqedTo)
                    .HasColumnType("date")
                    .HasColumnName("aqed_to");

                entity.Property(e => e.AqedType).HasColumnName("aqed_type");

                entity.Property(e => e.BillCostId).HasColumnName("BillCostID");

                entity.Property(e => e.BillCurnceyId).HasColumnName("BillCurnceyID");

                entity.Property(e => e.BillDeleteId).HasColumnName("BillDeleteID");

                entity.Property(e => e.BillMainId).HasColumnName("BillMainID");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.HourPrince)
                    .HasColumnType("money")
                    .HasColumnName("hour_prince");

                entity.Property(e => e.IltzamatTarafOne1).HasColumnName("iltzamat_taraf_one1");

                entity.Property(e => e.IltzamatTarafOne2).HasColumnName("iltzamat_taraf_one2");

                entity.Property(e => e.IltzamatTarafTwo1).HasColumnName("iltzamat_taraf_two1");

                entity.Property(e => e.IltzamatTarafTwo2).HasColumnName("iltzamat_taraf_two2");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsKafala).HasColumnName("is_kafala");

                entity.Property(e => e.IsWakeel).HasColumnName("is_wakeel");

                entity.Property(e => e.KafalaDate)
                    .HasColumnType("date")
                    .HasColumnName("kafala_date");

                entity.Property(e => e.KafalaMoney)
                    .HasColumnType("money")
                    .HasColumnName("kafala_money");

                entity.Property(e => e.KhedmaPeriod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("khedma_period");

                entity.Property(e => e.MonthTklofa)
                    .HasColumnType("money")
                    .HasColumnName("month_tklofa");

                entity.Property(e => e.MouqebMoney)
                    .HasColumnType("money")
                    .HasColumnName("mouqeb_money");

                entity.Property(e => e.MuaqpId).HasColumnName("muaqp_id");

                entity.Property(e => e.RecTId).HasColumnName("rec_t_id");

                entity.Property(e => e.SaatAmal).HasColumnName("saat_amal");

                entity.Property(e => e.SalaryAfterKafala)
                    .HasColumnType("money")
                    .HasColumnName("salary_after_kafala");

                entity.Property(e => e.StartHour).HasColumnName("start_hour");

                entity.Property(e => e.Usrname).HasColumnName("usrname");

                entity.Property(e => e.WakeelName)
                    .HasMaxLength(80)
                    .HasColumnName("wakeel_name");

                entity.HasOne(d => d.CIdNavigation)
                    .WithMany(p => p.AqedTa3jeerTbls)
                    .HasForeignKey(d => d.CId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aqed_ta3jeer_tbl_customer_tbl");
            });

            modelBuilder.Entity<AqedTajeerTransferTbl>(entity =>
            {
                entity.ToTable("aqed_tajeer_transfer_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedTajeerId).HasColumnName("aqed_tajeer_id");

                entity.Property(e => e.FromRecId).HasColumnName("from_rec_id");

                entity.Property(e => e.ToRecId).HasColumnName("to_rec_id");

                entity.Property(e => e.TransDate)
                    .HasColumnType("date")
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransNote).HasColumnName("trans_note");

                entity.Property(e => e.TransTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("trans_time");

                entity.Property(e => e.TransUser).HasColumnName("trans_user");

                entity.Property(e => e.UserDate)
                    .HasColumnType("datetime")
                    .HasColumnName("user_date");
            });

            modelBuilder.Entity<AqedTbl>(entity =>
            {
                entity.ToTable("aqed_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgeFrom).HasColumnName("age_from");

                entity.Property(e => e.AgeTo)
                    .HasColumnName("age_to")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.AirportId).HasColumnName("airport_id");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AqedDateH)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("aqed_date_h");

                entity.Property(e => e.AqedFrom)
                    .HasColumnType("date")
                    .HasColumnName("aqed_from");

                entity.Property(e => e.AqedPeriod)
                    .HasColumnName("aqed_period")
                    .HasDefaultValueSql("((120))");

                entity.Property(e => e.AqedSource).HasColumnName("aqed_source");

                entity.Property(e => e.AqedStatusInMusaned)
                    .HasMaxLength(100)
                    .HasColumnName("aqed_status_in_musaned");

                entity.Property(e => e.AqedTo)
                    .HasColumnType("date")
                    .HasColumnName("aqed_to");

                entity.Property(e => e.ArrivalBillId).HasColumnName("arrival_bill_id");

                entity.Property(e => e.ArrivalRetBillId).HasColumnName("arrival_ret_bill_id");

                entity.Property(e => e.ArrivalRetYearId).HasColumnName("arrival_ret_year_id");

                entity.Property(e => e.ArrivalYearId).HasColumnName("arrival_year_id");

                entity.Property(e => e.BillDeleteId).HasColumnName("BillDeleteID");

                entity.Property(e => e.BillMainId).HasColumnName("BillMainID");

                entity.Property(e => e.BillRecId).HasColumnName("BillRecID");

                entity.Property(e => e.ChvisaDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chvisa_date");

                entity.Property(e => e.Ckarrivel).HasColumnName("CKArrivel");

                entity.Property(e => e.Ckstat).HasColumnName("CKStat");

                entity.Property(e => e.Ckticket).HasColumnName("CKTicket");

                entity.Property(e => e.CkticketDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CKTicket_date");

                entity.Property(e => e.Ckvisa).HasColumnName("CKVisa");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CurnceyId).HasColumnName("CurnceyID");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.DateDelete)
                    .HasColumnType("date")
                    .HasColumnName("date_delete");

                entity.Property(e => e.DisCountVl)
                    .HasColumnName("DisCountVL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dm)
                    .HasMaxLength(50)
                    .HasColumnName("dm");

                entity.Property(e => e.EightCond).HasColumnName("eight_cond");

                entity.Property(e => e.FourteenCond).HasColumnName("fourteen_cond");

                entity.Property(e => e.Idd)
                    .HasMaxLength(50)
                    .HasColumnName("idd");

                entity.Property(e => e.IjazaNum).HasColumnName("ijaza_num");

                entity.Property(e => e.IsAqed)
                    .IsRequired()
                    .HasColumnName("is_aqed")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDefined).HasColumnName("is_defined");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsNone).HasColumnName("is_none");

                entity.Property(e => e.IsPayedForVisa).HasColumnName("is_payed_for_visa");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.IsSpeed).HasColumnName("is_speed");

                entity.Property(e => e.IsVip).HasColumnName("is_vip");

                entity.Property(e => e.IsWakeel).HasColumnName("is_wakeel");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.MuaqpId).HasColumnName("muaqp_id");

                entity.Property(e => e.MuaqpMoney).HasColumnName("muaqp_money");

                entity.Property(e => e.MusanedToOurAccountPayed)
                    .HasColumnType("money")
                    .HasColumnName("musaned_to_our_account_payed");

                entity.Property(e => e.MusanedToOurAccountPayedDate)
                    .HasColumnType("date")
                    .HasColumnName("musaned_to_our_account_payed_date");

                entity.Property(e => e.MusanedTotalMoney)
                    .HasColumnType("money")
                    .HasColumnName("musaned_total_money");

                entity.Property(e => e.MusanedTotalPayed)
                    .HasColumnType("money")
                    .HasColumnName("musaned_total_payed");

                entity.Property(e => e.MusanedTotalPayedDate)
                    .HasColumnType("date")
                    .HasColumnName("musaned_total_payed_date");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.OfficerequirmentId).HasColumnName("officerequirmentID");

                entity.Property(e => e.OutsidemouqebId).HasColumnName("outsidemouqeb_id");

                entity.Property(e => e.OutsidemouqebMoney)
                    .HasColumnType("money")
                    .HasColumnName("outsidemouqeb_money");

                entity.Property(e => e.Pt)
                    .HasMaxLength(50)
                    .HasColumnName("pt");

                entity.Property(e => e.Pw)
                    .HasMaxLength(50)
                    .HasColumnName("pw");

                entity.Property(e => e.RecCount).HasColumnName("rec_count");

                entity.Property(e => e.ReleginId).HasColumnName("relegin_id");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("return_date");

                entity.Property(e => e.ReturnValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.SadadType).HasColumnName("sadad_type");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.SevenCond).HasColumnName("seven_cond");

                entity.Property(e => e.TaakherAmount)
                    .HasColumnType("money")
                    .HasColumnName("taakher_amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.UserDelete).HasColumnName("user_delete");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.VisaIsOur).HasColumnName("visa_is_our");

                entity.Property(e => e.VisaMoney)
                    .HasColumnType("money")
                    .HasColumnName("visa_money");

                entity.Property(e => e.VisaSource)
                    .HasMaxLength(100)
                    .HasColumnName("visa_source");

                entity.Property(e => e.Visadate)
                    .HasColumnType("date")
                    .HasColumnName("visadate");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");

                entity.Property(e => e.Wakeelname)
                    .HasMaxLength(150)
                    .HasColumnName("wakeelname");

                entity.Property(e => e.WhoPayedToMusaned).HasColumnName("who_payed_to_musaned");

                entity.Property(e => e.YearId).HasColumnName("year_id");

                entity.Property(e => e.YearIdRet).HasColumnName("year_id_ret");
            });

            modelBuilder.Entity<AqedView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("aqed_view");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedSource).HasColumnName("aqed_source");

                entity.Property(e => e.Aqedmoney)
                    .HasColumnType("money")
                    .HasColumnName("aqedmoney");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Finalrbh)
                    .HasColumnType("money")
                    .HasColumnName("finalrbh");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDefined).HasColumnName("is_defined");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsNone).HasColumnName("is_none");

                entity.Property(e => e.IsPayedForVisa).HasColumnName("is_payed_for_visa");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.IsSpeed).HasColumnName("is_speed");

                entity.Property(e => e.IsVip).HasColumnName("is_vip");

                entity.Property(e => e.Isdel).HasColumnName("isdel");

                entity.Property(e => e.Mouqebmoney)
                    .HasColumnType("money")
                    .HasColumnName("mouqebmoney");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.Numrec).HasColumnName("numrec");

                entity.Property(e => e.Paymentmony)
                    .HasColumnType("money")
                    .HasColumnName("paymentmony");

                entity.Property(e => e.RecRes).HasColumnName("rec_res");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TotalOffice)
                    .HasColumnType("money")
                    .HasColumnName("total_office");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<AqerdPrintView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AqerdPrintView");

                entity.Property(e => e.AgeFrom).HasColumnName("age_from");

                entity.Property(e => e.AgeTo).HasColumnName("age_to");

                entity.Property(e => e.Airport)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("airport");

                entity.Property(e => e.AirportEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("airport_en");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedDateH)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("aqed_date_h");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("country_name");

                entity.Property(e => e.CusJop)
                    .HasMaxLength(50)
                    .HasColumnName("Cus_Jop");

                entity.Property(e => e.CusOld)
                    .HasMaxLength(50)
                    .HasColumnName("Cus_Old");

                entity.Property(e => e.EightCond).HasColumnName("eight_cond");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FourteenCond).HasColumnName("fourteen_cond");

                entity.Property(e => e.HasExper).HasColumnName("has_exper");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.JobEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("job_en");

                entity.Property(e => e.KidsNum).HasColumnName("kids_num");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nationality");

                entity.Property(e => e.OtherPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("other_phone");

                entity.Property(e => e.OwnerAddressAr)
                    .HasMaxLength(350)
                    .HasColumnName("owner_address_ar");

                entity.Property(e => e.OwnerChildNum).HasColumnName("owner_child_num");

                entity.Property(e => e.Passportedate)
                    .HasColumnType("date")
                    .HasColumnName("passportedate");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.Passportplace)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("passportplace");

                entity.Property(e => e.Passportsdate)
                    .HasColumnType("date")
                    .HasColumnName("passportsdate");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Rcphone)
                    .HasMaxLength(50)
                    .HasColumnName("RCphone");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.RelegionEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("relegion_en");

                entity.Property(e => e.SakanType)
                    .HasMaxLength(50)
                    .HasColumnName("sakan_type");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.SevenCond).HasColumnName("seven_cond");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.VisaSource)
                    .HasMaxLength(100)
                    .HasColumnName("visa_source");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<Arrival>(entity =>
            {
                entity.ToTable("arrival");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Airplane)
                    .HasMaxLength(300)
                    .HasColumnName("airplane");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.AriportId).HasColumnName("ariport_id");

                entity.Property(e => e.ArrType)
                    .HasMaxLength(50)
                    .HasColumnName("arr_type")
                    .HasDefaultValueSql("(N'وصول')");

                entity.Property(e => e.ArrivaleDate)
                    .HasColumnType("date")
                    .HasColumnName("arrivale_date");

                entity.Property(e => e.ArrivaleTime).HasColumnName("arrivale_time");

                entity.Property(e => e.Flyno)
                    .HasMaxLength(50)
                    .HasColumnName("flyno");

                entity.Property(e => e.Insurance).HasColumnName("insurance");

                entity.Property(e => e.IsArrive)
                    .IsRequired()
                    .HasColumnName("is_arrive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.YearClose).HasColumnName("year_close");

                entity.Property(e => e.YearId).HasColumnName("year_id");

                entity.HasOne(d => d.Aqed)
                    .WithMany(p => p.Arrivals)
                    .HasForeignKey(d => d.AqedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_arrival_aqed_tbl");

                entity.HasOne(d => d.Ariport)
                    .WithMany(p => p.Arrivals)
                    .HasForeignKey(d => d.AriportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_arrival_airport_tbl");

                entity.HasOne(d => d.Rec)
                    .WithMany(p => p.Arrivals)
                    .HasForeignKey(d => d.RecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_arrival_recruitmenter_tbl");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId, "IX_RoleId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AttachmentAllTbl>(entity =>
            {
                entity.ToTable("attachment_all_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttachFile).HasColumnName("attach_file");

                entity.Property(e => e.CvFileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cv_file_name");

                entity.Property(e => e.SourcType).HasColumnName("sourc_type");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.UpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("up_date");

                entity.Property(e => e.UserName).HasColumnName("user_name");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<AttachmentTbl>(entity =>
            {
                entity.ToTable("attachment_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.AttachDate)
                    .HasColumnType("date")
                    .HasColumnName("attach_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AttachtypeId).HasColumnName("attachtype_id");

                entity.Property(e => e.FileImage)
                    .HasColumnType("image")
                    .HasColumnName("file_image");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Aqed)
                    .WithMany(p => p.AttachmentTbls)
                    .HasForeignKey(d => d.AqedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_attachment_tbl_aqed_tbl");

                entity.HasOne(d => d.Attachtype)
                    .WithMany(p => p.AttachmentTbls)
                    .HasForeignKey(d => d.AttachtypeId)
                    .HasConstraintName("FK_attachment_tbl_attachmentType");
            });

            modelBuilder.Entity<AttachmentType>(entity =>
            {
                entity.ToTable("attachmentType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttcahName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Attcah_name");
            });

            modelBuilder.Entity<BalanceSheetView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BalanceSheetView");

                entity.Property(e => e.Accdlt).HasColumnName("ACCDLT");

                entity.Property(e => e.AccountCode).HasMaxLength(150);

                entity.Property(e => e.Acctyp).HasColumnName("ACCTYP");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AcountName).HasMaxLength(250);

                entity.Property(e => e.EndInvl).HasColumnName("EndINVL");

                entity.Property(e => e.EndOutVl).HasColumnName("EndOutVL");

                entity.Property(e => e.Totinvl).HasColumnName("TOTINVL");

                entity.Property(e => e.Tottvl).HasColumnName("TOTTVL");
            });

            modelBuilder.Entity<BeforeaqedTbl>(entity =>
            {
                entity.ToTable("beforeaqed_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedNum).HasColumnName("aqed_num");

                entity.Property(e => e.IsAqed).HasColumnName("is_aqed");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.KAddress)
                    .HasMaxLength(250)
                    .HasColumnName("k_address");

                entity.Property(e => e.KDate)
                    .HasColumnType("date")
                    .HasColumnName("k_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KMob)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("k_mob");

                entity.Property(e => e.KName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("k_name");

                entity.Property(e => e.KSpec).HasColumnName("k_spec");

                entity.Property(e => e.NatId).HasColumnName("nat_id");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Benefit>(entity =>
            {
                entity.ToTable("benefit");

                entity.Property(e => e.BenefitId).HasColumnName("benefit_id");

                entity.Property(e => e.BenefitName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("benefit_name");
            });

            modelBuilder.Entity<BillAccHdview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillAccHDView");

                entity.Property(e => e.BillHeaderDate).HasColumnType("date");

                entity.Property(e => e.BillHeaderId).HasColumnName("BillHeaderID");

                entity.Property(e => e.BillHeaderTybeId).HasColumnName("BillHeaderTybeID");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<BillAccView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillAccView");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AcountName).HasMaxLength(250);

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillOutvalue).HasColumnName("BillOUTValue");

                entity.Property(e => e.BillType).HasMaxLength(50);

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MainBillId).HasColumnName("MainBillID");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<BillHeaderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillHeaderView");

                entity.Property(e => e.BillHeaderDate).HasColumnType("date");

                entity.Property(e => e.BillHeaderId).HasColumnName("BillHeaderID");

                entity.Property(e => e.BillHeaderTybeId).HasColumnName("BillHeaderTybeID");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<BillInView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillInView");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AcountName).HasMaxLength(250);

                entity.Property(e => e.Actoid).HasColumnName("ACTOID");

                entity.Property(e => e.Actoname)
                    .HasMaxLength(250)
                    .HasColumnName("ACTOName");

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillType).HasMaxLength(50);

                entity.Property(e => e.BillTypeDt)
                    .HasColumnType("date")
                    .HasColumnName("BillTypeDT");

                entity.Property(e => e.BillTypeId)
                    .HasMaxLength(150)
                    .HasColumnName("BillTypeID");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.FaturaType)
                    .HasMaxLength(150)
                    .HasColumnName("fatura_type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsFatura).HasColumnName("is_fatura");

                entity.Property(e => e.MainBillId).HasColumnName("MainBillID");

                entity.Property(e => e.SadadType).HasColumnName("sadad_type");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.Taxamount)
                    .HasColumnType("money")
                    .HasColumnName("taxamount");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.Withouttax).HasColumnName("withouttax");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<BillOutView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillOutView");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AcountName).HasMaxLength(250);

                entity.Property(e => e.Actoid).HasColumnName("ACTOID");

                entity.Property(e => e.Actoname)
                    .HasMaxLength(250)
                    .HasColumnName("ACTOName");

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillType).HasMaxLength(50);

                entity.Property(e => e.BillTypeDt)
                    .HasColumnType("date")
                    .HasColumnName("BillTypeDT");

                entity.Property(e => e.BillTypeId)
                    .HasMaxLength(150)
                    .HasColumnName("BillTypeID");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.FaturaType)
                    .HasMaxLength(150)
                    .HasColumnName("fatura_type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsFatura).HasColumnName("is_fatura");

                entity.Property(e => e.MainBillId).HasColumnName("MainBillID");

                entity.Property(e => e.SadadType).HasColumnName("sadad_type");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.Taxamount)
                    .HasColumnType("money")
                    .HasColumnName("taxamount");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.Withouttax).HasColumnName("withouttax");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<ConditionsTbl>(entity =>
            {
                entity.ToTable("conditions_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CondNameAr)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("cond_name_ar");

                entity.Property(e => e.CondNameEn)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cond_name_en");
            });

            modelBuilder.Entity<CustPricesTbl>(entity =>
            {
                entity.ToTable("cust_prices_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.NatId).HasColumnName("nat_id");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.RelejonId).HasColumnName("relejon_id");

                entity.Property(e => e.Visaprice)
                    .HasColumnType("money")
                    .HasColumnName("visaprice");
            });

            modelBuilder.Entity<CustomerOrdersview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("customerOrdersviews");

                entity.Property(e => e.AgeFrom).HasColumnName("age_from");

                entity.Property(e => e.AgeTo).HasColumnName("age_to");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("country_name");

                entity.Property(e => e.EightCond).HasColumnName("eight_cond");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.OwnerAddressAr)
                    .HasMaxLength(350)
                    .HasColumnName("owner_address_ar");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Reccount).HasColumnName("reccount");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.SevenCond).HasColumnName("seven_cond");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<CustomerTbl>(entity =>
            {
                entity.ToTable("customer_tbl");

                entity.HasIndex(e => e.IdNum, "customer_tbl_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BulldingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bullding_no");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.CusAccId).HasColumnName("CusAccID");

                entity.Property(e => e.CusJop)
                    .HasMaxLength(50)
                    .HasColumnName("Cus_Jop");

                entity.Property(e => e.CusOld)
                    .HasMaxLength(50)
                    .HasColumnName("Cus_Old");

                entity.Property(e => e.CusSonOld).HasColumnName("Cus_SonOld");

                entity.Property(e => e.CusWifeOld)
                    .HasMaxLength(50)
                    .HasColumnName("Cus_WifeOld");

                entity.Property(e => e.Custnote)
                    .HasMaxLength(500)
                    .HasColumnName("custnote");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FiilingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fiiling_no");

                entity.Property(e => e.FillingPlace)
                    .HasMaxLength(50)
                    .HasColumnName("filling_place");

                entity.Property(e => e.HomePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("home_phone")
                    .HasDefaultValueSql("(N'.....')");

                entity.Property(e => e.IdCN).HasColumnName("id_c_n");

                entity.Property(e => e.IdDated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_dated");

                entity.Property(e => e.IdDateofbirth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_dateofbirth");

                entity.Property(e => e.IdExpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_expdate");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IdPlace)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_place")
                    .HasDefaultValueSql("(N'.....')");

                entity.Property(e => e.IdPlaceOfBirthdate)
                    .HasMaxLength(50)
                    .HasColumnName("id_place_of_birthdate");

                entity.Property(e => e.IdPlaceOfIssued)
                    .HasMaxLength(50)
                    .HasColumnName("id_place_of_issued");

                entity.Property(e => e.IsBlacklist).HasColumnName("is_blacklist");

                entity.Property(e => e.Isoldpeoplr)
                    .HasColumnName("isoldpeoplr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Issickpeople)
                    .HasColumnName("issickpeople")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KidsNum)
                    .HasColumnName("kids_num")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nationality");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes")
                    .HasDefaultValueSql("(N'.....')");

                entity.Property(e => e.OtherPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("other_phone")
                    .HasDefaultValueSql("(N'.....')");

                entity.Property(e => e.OwnerAddressAr)
                    .HasMaxLength(350)
                    .HasColumnName("owner_address_ar");

                entity.Property(e => e.OwnerAddressEn)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("owner_address_en");

                entity.Property(e => e.OwnerAge)
                    .HasColumnName("owner_age")
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.OwnerChildNum).HasColumnName("owner_child_num");

                entity.Property(e => e.OwnerMadinaAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_madina_ar");

                entity.Property(e => e.OwnerMadinaEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("owner_madina_en");

                entity.Property(e => e.OwnerReginAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_regin_ar");

                entity.Property(e => e.OwnerReginEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("owner_regin_en");

                entity.Property(e => e.OwnerStatusAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_status_ar");

                entity.Property(e => e.OwnerStatusEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("owner_status_en");

                entity.Property(e => e.OwnerStreetAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_street_ar");

                entity.Property(e => e.OwnerStreetEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("owner_street_en");

                entity.Property(e => e.OwnernameEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ownername_en");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone")
                    .HasDefaultValueSql("(N'.....')");

                entity.Property(e => e.Postmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("postmail")
                    .HasDefaultValueSql("(N'.....')");

                entity.Property(e => e.Pox)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pox")
                    .HasDefaultValueSql("(N'.....')");

                entity.Property(e => e.SakanType)
                    .HasMaxLength(50)
                    .HasColumnName("sakan_type");

                entity.Property(e => e.Visanum)
                    .HasMaxLength(50)
                    .HasColumnName("visanum");
            });

            modelBuilder.Entity<CvView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cv_View");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("office_name");

                entity.Property(e => e.Passportno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.RecMobiile)
                    .HasMaxLength(50)
                    .HasColumnName("rec_mobiile");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");
            });

            modelBuilder.Entity<DataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dataView");

                entity.Property(e => e.Expr1)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<DateMonth>(entity =>
            {
                entity.ToTable("date_months");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<EmpAutoAttendance>(entity =>
            {
                entity.ToTable("emp_auto_attendance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateT)
                    .HasColumnType("date")
                    .HasColumnName("date_t");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.FromTime).HasColumnName("from_time");

                entity.Property(e => e.ToTime).HasColumnName("to_time");
            });

            modelBuilder.Entity<EmpBenefit>(entity =>
            {
                entity.ToTable("emp_benefit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.BenefitId).HasColumnName("benefit_id");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .HasColumnName("notes");

                entity.Property(e => e.PNote)
                    .HasMaxLength(300)
                    .HasColumnName("p_note");

                entity.Property(e => e.PayedDate)
                    .HasColumnType("date")
                    .HasColumnName("payed_date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.EmpBenefits)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_emp_benefit_account");

                entity.HasOne(d => d.Benefit)
                    .WithMany(p => p.EmpBenefits)
                    .HasForeignKey(d => d.BenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_emp_benefit_benefit");
            });

            modelBuilder.Entity<EmployeeContract>(entity =>
            {
                entity.ToTable("employee_Contract");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmployeeContracts)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employee_Contract_employee_tbl");
            });

            modelBuilder.Entity<EmployeeTbl>(entity =>
            {
                entity.ToTable("employee_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.EmpDegree)
                    .HasMaxLength(50)
                    .HasColumnName("emp_degree");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .HasColumnName("empID");

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNational)
                    .HasMaxLength(50)
                    .HasColumnName("emp_national");

                entity.Property(e => e.EmpPosition)
                    .HasMaxLength(50)
                    .HasColumnName("emp_position");

                entity.Property(e => e.EmpSalary)
                    .HasColumnType("money")
                    .HasColumnName("emp_salary");

                entity.Property(e => e.EmpSex)
                    .HasMaxLength(50)
                    .HasColumnName("emp_sex");

                entity.Property(e => e.EmpaccId).HasColumnName("EMPAccID");

                entity.Property(e => e.Empno)
                    .HasMaxLength(50)
                    .HasColumnName("empno");

                entity.Property(e => e.InsuranceEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("insurance_end_date");

                entity.Property(e => e.IqamaEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("iqama_end_date");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PassportEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("passport_end_date");

                entity.Property(e => e.SolfaAmount)
                    .HasColumnType("money")
                    .HasColumnName("solfa_amount");
            });

            modelBuilder.Entity<EmployerinformationrequestVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employerinformationrequest_VW");

                entity.Property(e => e.Address1)
                    .HasMaxLength(304)
                    .IsUnicode(false)
                    .HasColumnName("address_1");

                entity.Property(e => e.AgeFrom).HasColumnName("age_from");

                entity.Property(e => e.AgeTo).HasColumnName("age_to");

                entity.Property(e => e.Airport)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("airport");

                entity.Property(e => e.AqedDateH)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("aqed_date_h");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.CName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c_name");

                entity.Property(e => e.Housetype)
                    .HasMaxLength(50)
                    .HasColumnName("housetype");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.Isoldpeoplr).HasColumnName("isoldpeoplr");

                entity.Property(e => e.Issickpeople).HasColumnName("issickpeople");

                entity.Property(e => e.JobEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("job_en");

                entity.Property(e => e.KidsNum).HasColumnName("kids_num");

                entity.Property(e => e.NationalNameEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("national_name_en");

                entity.Property(e => e.Othernumbers)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("othernumbers");

                entity.Property(e => e.OwnerChildNum).HasColumnName("owner_child_num");

                entity.Property(e => e.Phonesnumber)
                    .IsRequired()
                    .HasMaxLength(105)
                    .HasColumnName("phonesnumber");

                entity.Property(e => e.RelegionEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("relegion_en");

                entity.Property(e => e.Salary1).HasColumnName("salary_1");

                entity.Property(e => e.SevenCond).HasColumnName("seven_cond");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<FaturaTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fatura_tbl");

                entity.Property(e => e.FAmount)
                    .HasColumnType("money")
                    .HasColumnName("f_amount");

                entity.Property(e => e.FDate)
                    .HasColumnType("datetime")
                    .HasColumnName("f_date");

                entity.Property(e => e.FDisc)
                    .IsRequired()
                    .HasColumnName("f_disc");

                entity.Property(e => e.FId).HasColumnName("f_id");

                entity.Property(e => e.FQabdSarf).HasColumnName("f_qabd_sarf");

                entity.Property(e => e.FQabdSarfId).HasColumnName("f_qabd_sarf_id");

                entity.Property(e => e.FTax)
                    .HasColumnType("money")
                    .HasColumnName("f_tax");

                entity.Property(e => e.FType)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("f_type");

                entity.Property(e => e.FYearId).HasColumnName("f_year_id");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.Towhom)
                    .HasMaxLength(250)
                    .HasColumnName("towhom");
            });

            modelBuilder.Entity<FillipoReportSitting>(entity =>
            {
                entity.ToTable("fillipo_report_sittings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldBind)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("field_bind");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("field_name");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GehatAlqodomTbl>(entity =>
            {
                entity.ToTable("GehatAlqodom_tbl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<GeneralSalesTbl>(entity =>
            {
                entity.ToTable("general_sales_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CName)
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.DateIn)
                    .HasColumnType("date")
                    .HasColumnName("date_in");

                entity.Property(e => e.InNo)
                    .HasMaxLength(50)
                    .HasColumnName("in_no");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .HasColumnName("notes");

                entity.Property(e => e.PName).HasColumnName("p_name");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmout)
                    .HasColumnType("money")
                    .HasColumnName("total_amout");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.GeneralSalesTbls)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_general_sales_tbl_account");

                entity.HasOne(d => d.PNameNavigation)
                    .WithMany(p => p.GeneralSalesTbls)
                    .HasForeignKey(d => d.PName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_general_sales_tbl_payed_name");
            });

            modelBuilder.Entity<HasamView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("hasam_view");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.HAmount).HasColumnName("h_amount");

                entity.Property(e => e.HDate)
                    .HasColumnType("date")
                    .HasColumnName("h_date");

                entity.Property(e => e.HNotes).HasColumnName("h_notes");

                entity.Property(e => e.HType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("h_type");

                entity.Property(e => e.HUser).HasColumnName("h_user");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<IncomeTbl>(entity =>
            {
                entity.ToTable("income_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.CustNo)
                    .HasMaxLength(50)
                    .HasColumnName("cust_no");

                entity.Property(e => e.FromHand)
                    .HasMaxLength(150)
                    .HasColumnName("from_hand");

                entity.Property(e => e.IncomeDate)
                    .HasColumnType("date")
                    .HasColumnName("income_date");

                entity.Property(e => e.IncomeType).HasColumnName("income_type");

                entity.Property(e => e.Notice).HasColumnName("notice");

                entity.Property(e => e.PNotice)
                    .HasMaxLength(50)
                    .HasColumnName("p_notice");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.ToAcc).HasColumnName("to_acc");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");

                entity.Property(e => e.Withouttax).HasColumnName("withouttax");

                entity.HasOne(d => d.IncomeTypeNavigation)
                    .WithMany(p => p.IncomeTbls)
                    .HasForeignKey(d => d.IncomeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_income_tbl_incometype");

                entity.HasOne(d => d.ToAccNavigation)
                    .WithMany(p => p.IncomeTbls)
                    .HasForeignKey(d => d.ToAcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_income_tbl_account");
            });

            modelBuilder.Entity<Incometype>(entity =>
            {
                entity.ToTable("incometype");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IncomeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("income_name");

                entity.Property(e => e.IsHidden).HasColumnName("is_hidden");
            });

            modelBuilder.Entity<InternalMsgTbl>(entity =>
            {
                entity.ToTable("internal_msg_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fromuser).HasColumnName("fromuser");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.MsgDetials).HasColumnName("msg_detials");

                entity.Property(e => e.ReadDate)
                    .HasColumnType("datetime")
                    .HasColumnName("read_date");

                entity.Property(e => e.SendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("send_date");

                entity.Property(e => e.Touser).HasColumnName("touser");
            });

            modelBuilder.Entity<JobTbl>(entity =>
            {
                entity.ToTable("job_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.JobEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("job_en");
            });

            modelBuilder.Entity<KafalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KafalView");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.Cusid).HasColumnName("CUSID");

                entity.Property(e => e.Cusname)
                    .HasMaxLength(100)
                    .HasColumnName("CUSName");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.HandDate)
                    .HasColumnType("date")
                    .HasColumnName("hand_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNum)
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.KdayTot)
                    .HasMaxLength(50)
                    .HasColumnName("KDayTOT");

                entity.Property(e => e.KendDt)
                    .HasColumnType("date")
                    .HasColumnName("KEndDT");

                entity.Property(e => e.Kok).HasColumnName("KOK");

                entity.Property(e => e.KstartDt)
                    .HasColumnType("date")
                    .HasColumnName("KStartDT");

                entity.Property(e => e.NationalName)
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.NewCusId).HasColumnName("NewCusID");

                entity.Property(e => e.NewCusIdnum)
                    .HasMaxLength(50)
                    .HasColumnName("NewCusIDNum");

                entity.Property(e => e.NewCusName).HasMaxLength(100);

                entity.Property(e => e.NewCusPhone).HasMaxLength(50);

                entity.Property(e => e.NewCust)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("new_cust");

                entity.Property(e => e.NewCustId)
                    .HasMaxLength(50)
                    .HasColumnName("new_cust_id");

                entity.Property(e => e.NewCustMob)
                    .HasMaxLength(50)
                    .HasColumnName("new_cust_mob");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasColumnName("notes");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Rcid).HasColumnName("RCID");

                entity.Property(e => e.ReachDate)
                    .HasColumnType("date")
                    .HasColumnName("reach_date");

                entity.Property(e => e.RecId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("rec_id");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.Remain)
                    .HasColumnType("money")
                    .HasColumnName("remain");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasColumnName("total_amount");
            });

            modelBuilder.Entity<KafalaMoney>(entity =>
            {
                entity.ToTable("kafala_money");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.KId).HasColumnName("k_id");

                entity.Property(e => e.MDate)
                    .HasColumnType("date")
                    .HasColumnName("m_date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .HasColumnName("notes");

                entity.Property(e => e.PayNotes)
                    .HasMaxLength(300)
                    .HasColumnName("pay_notes");

                entity.Property(e => e.PaymentType).HasColumnName("payment_type");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.Withouttax).HasColumnName("withouttax");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.KafalaMoneys)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kafala_money_account");

                entity.HasOne(d => d.KIdNavigation)
                    .WithMany(p => p.KafalaMoneys)
                    .HasForeignKey(d => d.KId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kafala_money_kafala_tbl");
            });

            modelBuilder.Entity<KafalaReportVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("kafala_report_vw");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("enddate");

                entity.Property(e => e.HandDate)
                    .HasColumnType("date")
                    .HasColumnName("hand_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.NewCust)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("new_cust");

                entity.Property(e => e.NewCustId)
                    .HasMaxLength(50)
                    .HasColumnName("new_cust_id");

                entity.Property(e => e.NewCustMob)
                    .HasMaxLength(50)
                    .HasColumnName("new_cust_mob");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.Payedamuont)
                    .HasColumnType("money")
                    .HasColumnName("payedamuont");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.Remainamount)
                    .HasColumnType("money")
                    .HasColumnName("remainamount");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasColumnName("total_amount");
            });

            modelBuilder.Entity<KafalaTbl>(entity =>
            {
                entity.ToTable("kafala_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.HandDate)
                    .HasColumnType("date")
                    .HasColumnName("hand_date");

                entity.Property(e => e.KdayTot)
                    .HasMaxLength(50)
                    .HasColumnName("KDayTOT");

                entity.Property(e => e.KendDt)
                    .HasColumnType("date")
                    .HasColumnName("KEndDT");

                entity.Property(e => e.Kok).HasColumnName("KOK");

                entity.Property(e => e.KrecId).HasColumnName("KRecID");

                entity.Property(e => e.KstartDt)
                    .HasColumnType("date")
                    .HasColumnName("KStartDT");

                entity.Property(e => e.NewCust)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("new_cust");

                entity.Property(e => e.NewCustId)
                    .HasMaxLength(50)
                    .HasColumnName("new_cust_id");

                entity.Property(e => e.NewCustId1).HasColumnName("NewCustID");

                entity.Property(e => e.NewCustMob)
                    .HasMaxLength(50)
                    .HasColumnName("new_cust_mob");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasColumnName("notes");

                entity.Property(e => e.ReachDate)
                    .HasColumnType("date")
                    .HasColumnName("reach_date");

                entity.Property(e => e.RecId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("rec_id");

                entity.Property(e => e.Remain)
                    .HasColumnType("money")
                    .HasColumnName("remain");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasColumnName("total_amount");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.KafalaTbls)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kafala_tbl_customer_tbl");
            });

            modelBuilder.Entity<KafalaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("kafala_view");

                entity.Property(e => e.ArrivaleDate)
                    .HasColumnType("date")
                    .HasColumnName("arrivale_date");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rcid).HasColumnName("RCID");

                entity.Property(e => e.RecId)
                    .HasMaxLength(200)
                    .HasColumnName("rec_id");
            });

            modelBuilder.Entity<LogTbl>(entity =>
            {
                entity.ToTable("log_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tran_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TranTable)
                    .HasMaxLength(200)
                    .HasColumnName("tran_table");

                entity.Property(e => e.TransLog).HasColumnName("trans_log");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("trans_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<MadyonaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Madyona_View");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedSource).HasColumnName("aqed_source");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsAqed).HasColumnName("is_aqed");

                entity.Property(e => e.IsDefined).HasColumnName("is_defined");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsNone).HasColumnName("is_none");

                entity.Property(e => e.IsPayedForVisa).HasColumnName("is_payed_for_visa");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.IsSpeed).HasColumnName("is_speed");

                entity.Property(e => e.IsVip).HasColumnName("is_vip");

                entity.Property(e => e.LastStatus).HasMaxLength(4000);

                entity.Property(e => e.Lastpaymentdate)
                    .HasColumnType("date")
                    .HasColumnName("lastpaymentdate");

                entity.Property(e => e.Mouqeb)
                    .HasMaxLength(4000)
                    .HasColumnName("mouqeb");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.Paymentmony)
                    .HasColumnType("money")
                    .HasColumnName("paymentmony");

                entity.Property(e => e.RemainBalance).HasColumnName("remain_balance");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.VisaIsOur).HasColumnName("visa_is_our");

                entity.Property(e => e.Visano)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<MainBillInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MainBillInfo");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AcountName).HasMaxLength(250);

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillOutvalue).HasColumnName("BillOUTValue");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PNotice)
                    .HasMaxLength(50)
                    .HasColumnName("p_notice");

                entity.Property(e => e.SubBillId).HasColumnName("SubBillID");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Mo3amalatDa3raVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Mo3amalat_Da3ra_vw");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Countarrival).HasColumnName("countarrival");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("country_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.Officename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("officename");

                entity.Property(e => e.RecCount).HasColumnName("rec_count");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<MonthlySalary>(entity =>
            {
                entity.ToTable("monthly_salary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.AdditionalPay)
                    .HasColumnType("money")
                    .HasColumnName("additional_pay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateId).HasColumnName("date_id");

                entity.Property(e => e.Discount)
                    .HasColumnType("money")
                    .HasColumnName("discount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.HandDate)
                    .HasColumnType("datetime")
                    .HasColumnName("hand_date");

                entity.Property(e => e.InsurancePay)
                    .HasColumnType("money")
                    .HasColumnName("insurance_pay");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.MonthlySalaries)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_monthly_salary_employee_tbl");
            });

            modelBuilder.Entity<MouqebMoney>(entity =>
            {
                entity.ToTable("mouqeb_money");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.DDate)
                    .HasColumnType("date")
                    .HasColumnName("d_date");

                entity.Property(e => e.MuaqeId).HasColumnName("muaqe_id");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .HasColumnName("notes");

                entity.Property(e => e.PayNotes)
                    .HasMaxLength(300)
                    .HasColumnName("pay_notes");

                entity.Property(e => e.RecId)
                    .HasColumnName("rec_id")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.MouqebMoneys)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mouqeb_money_account");

                entity.HasOne(d => d.Aqed)
                    .WithMany(p => p.MouqebMoneys)
                    .HasForeignKey(d => d.AqedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mouqeb_money_aqed_tbl");

                entity.HasOne(d => d.Muaqe)
                    .WithMany(p => p.MouqebMoneys)
                    .HasForeignKey(d => d.MuaqeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mouqeb_money_muaqeb");
            });

            modelBuilder.Entity<Mouqebviewmoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mouqebviewmoney");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MuaqebName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("muaqeb_name");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");
            });

            modelBuilder.Entity<Muaqeb>(entity =>
            {
                entity.ToTable("muaqeb");

                entity.Property(e => e.MuaqebId).HasColumnName("muaqeb_id");

                entity.Property(e => e.MoaccId).HasColumnName("MOAccID");

                entity.Property(e => e.MuaqebName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("muaqeb_name");

                entity.Property(e => e.MuaqebPhone)
                    .HasMaxLength(50)
                    .HasColumnName("muaqeb_phone");
            });

            modelBuilder.Entity<Muaqebmonyview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("muaqebmonyview");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedSource).HasColumnName("aqed_source");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MuaqebId).HasColumnName("muaqeb_id");

                entity.Property(e => e.MuaqebName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("muaqeb_name");

                entity.Property(e => e.MuaqpMoney).HasColumnName("muaqp_money");

                entity.Property(e => e.Res).HasColumnName("res");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasColumnName("total");

                entity.Property(e => e.Visadate)
                    .HasColumnType("date")
                    .HasColumnName("visadate");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<NationalityTbl>(entity =>
            {
                entity.ToTable("nationality_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("country_name");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.NationalNameEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("national_name_en");
            });

            modelBuilder.Entity<OfficeDiscountPayment>(entity =>
            {
                entity.ToTable("office_discount_payments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.AmountUs).HasColumnName("amount_us");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("cust_name")
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.OfficeId).HasColumnName("officeID");

                entity.Property(e => e.Paydate)
                    .HasColumnType("date")
                    .HasColumnName("paydate");

                entity.Property(e => e.PaymentType).HasColumnName("payment_type");

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(50)
                    .HasColumnName("return_type");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.OfficeDiscountPayments)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_office_discount_payments_account");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.OfficeDiscountPayments)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_office_discount_payments_office_tbl");
            });

            modelBuilder.Entity<OfficeInfo>(entity =>
            {
                entity.ToTable("office_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdressAr)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("adress_ar");

                entity.Property(e => e.AdressEn)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("adress_en");

                entity.Property(e => e.ArivalSms)
                    .HasMaxLength(600)
                    .HasColumnName("Arival_sms");

                entity.Property(e => e.CloseUser).HasColumnName("close_user");

                entity.Property(e => e.Closedate)
                    .HasColumnType("date")
                    .HasColumnName("closedate");

                entity.Property(e => e.DistAr)
                    .HasMaxLength(150)
                    .HasColumnName("dist_ar");

                entity.Property(e => e.DistEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("dist_en");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Fone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fone");

                entity.Property(e => e.FooterImg)
                    .HasMaxLength(250)
                    .HasColumnName("footer_img");

                entity.Property(e => e.HeaderImg)
                    .HasMaxLength(250)
                    .HasColumnName("header_img");

                entity.Property(e => e.LNameAr)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("l_name_ar");

                entity.Property(e => e.LNameEn)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("l_name_en");

                entity.Property(e => e.LicDate)
                    .HasMaxLength(50)
                    .HasColumnName("lic_date");

                entity.Property(e => e.LicNum)
                    .HasMaxLength(50)
                    .HasColumnName("lic_num");

                entity.Property(e => e.Logo)
                    .HasColumnType("image")
                    .HasColumnName("logo");

                entity.Property(e => e.MusanedAccount).HasColumnName("musaned_account");

                entity.Property(e => e.MusanedToOurAccount).HasColumnName("musaned_to_our_account");

                entity.Property(e => e.NewAqedFlag).HasColumnName("new_aqed_flag");

                entity.Property(e => e.NewAqedSms)
                    .HasMaxLength(600)
                    .HasColumnName("New_aqed_sms");

                entity.Property(e => e.OfficeMail)
                    .HasMaxLength(50)
                    .HasColumnName("office_mail");

                entity.Property(e => e.OfficePox)
                    .HasMaxLength(50)
                    .HasColumnName("office_pox");

                entity.Property(e => e.OriginAr)
                    .HasMaxLength(150)
                    .HasColumnName("origin_ar");

                entity.Property(e => e.OriginEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("origin_en");

                entity.Property(e => e.OwnerSefaAr)
                    .HasMaxLength(100)
                    .HasColumnName("owner_sefa_ar");

                entity.Property(e => e.OwnerSefaEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("owner_sefa_en");

                entity.Property(e => e.OwnernameAr)
                    .HasMaxLength(150)
                    .HasColumnName("ownername_ar");

                entity.Property(e => e.OwnernameEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ownername_en");

                entity.Property(e => e.SafaraLoc)
                    .HasMaxLength(50)
                    .HasColumnName("safara_loc");

                entity.Property(e => e.Sejel)
                    .HasMaxLength(50)
                    .HasColumnName("sejel");

                entity.Property(e => e.SejelAddress)
                    .HasMaxLength(250)
                    .HasColumnName("sejel_address");

                entity.Property(e => e.SejelDate)
                    .HasMaxLength(50)
                    .HasColumnName("sejel_date");

                entity.Property(e => e.SejelNum)
                    .HasMaxLength(50)
                    .HasColumnName("sejel_num");

                entity.Property(e => e.SmsCheckbalance)
                    .HasMaxLength(1000)
                    .HasColumnName("sms_checkbalance");

                entity.Property(e => e.SmsOkCode)
                    .HasMaxLength(50)
                    .HasColumnName("sms_ok_code");

                entity.Property(e => e.SmsPass)
                    .HasMaxLength(50)
                    .HasColumnName("sms_pass");

                entity.Property(e => e.SmsSender)
                    .HasMaxLength(50)
                    .HasColumnName("sms_sender");

                entity.Property(e => e.SmsUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("sms_url");

                entity.Property(e => e.SmsUser)
                    .HasMaxLength(50)
                    .HasColumnName("sms_user");

                entity.Property(e => e.StreatAr)
                    .HasMaxLength(150)
                    .HasColumnName("streat_ar");

                entity.Property(e => e.StreatEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("streat_en");

                entity.Property(e => e.Tarkhees)
                    .HasMaxLength(50)
                    .HasColumnName("tarkhees");

                entity.Property(e => e.Taxnum)
                    .HasMaxLength(50)
                    .HasColumnName("taxnum");

                entity.Property(e => e.Taxvalue).HasColumnName("taxvalue");

                entity.Property(e => e.Vochournote)
                    .HasMaxLength(150)
                    .HasColumnName("vochournote");

                entity.Property(e => e.Websiturl)
                    .HasMaxLength(50)
                    .HasColumnName("websiturl");
            });

            modelBuilder.Entity<OfficeMoneyTbl>(entity =>
            {
                entity.ToTable("office_money_tbl");

                entity.HasIndex(e => new { e.OfficeId, e.JobId, e.ReleginId }, "UQ_codes")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.PriceUs).HasColumnName("price_US");

                entity.Property(e => e.ReleginId).HasColumnName("relegin_id");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.OfficeMoneyTbls)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_office_money_tbl_job_tbl");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.OfficeMoneyTbls)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_office_money_tbl_office_tbl");

                entity.HasOne(d => d.Relegin)
                    .WithMany(p => p.OfficeMoneyTbls)
                    .HasForeignKey(d => d.ReleginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_office_money_tbl_relegion_tbl");
            });

            modelBuilder.Entity<OfficePayment>(entity =>
            {
                entity.ToTable("office_payments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.AmountUs).HasColumnName("amount_us");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("cust_name")
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.OfficeId).HasColumnName("officeID");

                entity.Property(e => e.Paydate)
                    .HasColumnType("date")
                    .HasColumnName("paydate");

                entity.Property(e => e.PaymentType).HasColumnName("payment_type");

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(50)
                    .HasColumnName("return_type");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.OfficePayments)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_office_payments_account");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.OfficePayments)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_office_payments_office_tbl");
            });

            modelBuilder.Entity<OfficeRequirmentVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OfficeRequirmentVW");

                entity.Property(e => e.AirportEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("airport_en");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.JobEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("job_en");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(4000)
                    .HasColumnName("last_status");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.OfficerequirmentId).HasColumnName("officerequirmentID");

                entity.Property(e => e.Officesend)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("officesend");

                entity.Property(e => e.OwnernameEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ownername_en");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.RecCount).HasColumnName("rec_count");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<OfficeTbl>(entity =>
            {
                entity.ToTable("office_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aqentname)
                    .HasMaxLength(50)
                    .HasColumnName("aqentname");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IsBlacklist)
                    .HasColumnName("is_blacklist")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OfaccId).HasColumnName("OFAccID");

                entity.Property(e => e.OfficeAddress)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("office_address");

                entity.Property(e => e.OfficeAddressAr)
                    .HasMaxLength(150)
                    .HasColumnName("office_address_ar");

                entity.Property(e => e.OfficeDist)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("office_dist");

                entity.Property(e => e.OfficeDistAr)
                    .HasMaxLength(150)
                    .HasColumnName("office_dist_ar");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("office_name");

                entity.Property(e => e.OfficeNameAr)
                    .HasMaxLength(150)
                    .HasColumnName("office_name_ar");

                entity.Property(e => e.OfficeNote)
                    .HasMaxLength(500)
                    .HasColumnName("office_note");

                entity.Property(e => e.OfficePhones)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("office_phones");

                entity.Property(e => e.OfficeStreat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("office_streat");

                entity.Property(e => e.OfficeStreatAr)
                    .HasMaxLength(150)
                    .HasColumnName("office_streat_ar");

                entity.Property(e => e.Trkhees)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("trkhees");
            });

            modelBuilder.Entity<Officemoneyview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("officemoneyview");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("office_name");

                entity.Property(e => e.OfficePrice)
                    .HasColumnType("money")
                    .HasColumnName("office_price");

                entity.Property(e => e.Officeid).HasColumnName("officeid");

                entity.Property(e => e.Paymentmony)
                    .HasColumnType("money")
                    .HasColumnName("paymentmony");

                entity.Property(e => e.RecName)
                    .HasMaxLength(4000)
                    .HasColumnName("rec_name");

                entity.Property(e => e.RemainBalance).HasColumnName("remain_balance");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.Totaldiscountpayments).HasColumnName("totaldiscountpayments");

                entity.Property(e => e.Totalpayments).HasColumnName("totalpayments");

                entity.Property(e => e.Totalremain)
                    .HasColumnType("money")
                    .HasColumnName("totalremain");

                entity.Property(e => e.Totalreturn).HasColumnName("totalreturn");
            });

            modelBuilder.Entity<OfficerequirmentTbl>(entity =>
            {
                entity.ToTable("officerequirment_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("countryID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasColumnName("notes");

                entity.Property(e => e.Officeid).HasColumnName("officeid");

                entity.Property(e => e.ReqDate)
                    .HasColumnType("date")
                    .HasColumnName("req_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqUser).HasColumnName("req_user");
            });

            modelBuilder.Entity<OtherServicesTbl>(entity =>
            {
                entity.ToTable("otherServices_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CCust)
                    .HasMaxLength(50)
                    .HasColumnName("c_cust");

                entity.Property(e => e.CPhone)
                    .HasMaxLength(50)
                    .HasColumnName("c_phone");

                entity.Property(e => e.CustName).HasColumnName("cust_name");

                entity.Property(e => e.PayedMoney)
                    .HasColumnType("money")
                    .HasColumnName("payed_money");

                entity.Property(e => e.SDate)
                    .HasColumnType("datetime")
                    .HasColumnName("s_date");

                entity.Property(e => e.SDisc).HasColumnName("s_disc");

                entity.Property(e => e.TotalMoney)
                    .HasColumnType("money")
                    .HasColumnName("total_money");
            });

            modelBuilder.Entity<PayedName>(entity =>
            {
                entity.ToTable("payed_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsHidden).HasColumnName("is_hidden");

                entity.Property(e => e.MName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("m_name");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.Notce)
                    .HasMaxLength(300)
                    .HasColumnName("notce");

                entity.Property(e => e.PayNotce)
                    .HasMaxLength(300)
                    .HasColumnName("pay_notce");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.Withouttax).HasColumnName("withouttax");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_payment_account");

                entity.HasOne(d => d.Aqed)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.AqedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_payment_aqed_tbl");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permission");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PermissionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("permission_type");
            });

            modelBuilder.Entity<PredefindeReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("predefindeReport");

                entity.Property(e => e.Address)
                    .HasMaxLength(350)
                    .HasColumnName("address");

                entity.Property(e => e.AgeFrom).HasColumnName("age_from");

                entity.Property(e => e.AgeTo).HasColumnName("age_to");

                entity.Property(e => e.Airport)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("airport");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedDateH)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("aqed_date_h");

                entity.Property(e => e.AqedFrom)
                    .HasColumnType("date")
                    .HasColumnName("aqed_from");

                entity.Property(e => e.AqedPeriod).HasColumnName("aqed_period");

                entity.Property(e => e.AqedTo)
                    .HasColumnType("date")
                    .HasColumnName("aqed_to");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.DayName)
                    .HasMaxLength(30)
                    .HasColumnName("day_name");

                entity.Property(e => e.EightCond).HasColumnName("eight_cond");

                entity.Property(e => e.FinalAmount).HasColumnName("final_amount");

                entity.Property(e => e.FourteenCond).HasColumnName("fourteen_cond");

                entity.Property(e => e.HomePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("home_phone");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IdPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_place");

                entity.Property(e => e.IjazaNum).HasColumnName("ijaza_num");

                entity.Property(e => e.IsDefined).HasColumnName("is_defined");

                entity.Property(e => e.IsWakeel).HasColumnName("is_wakeel");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nationality");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("office_name");

                entity.Property(e => e.OtherPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("other_phone");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Postmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("postmail");

                entity.Property(e => e.Pox)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pox");

                entity.Property(e => e.RecCount).HasColumnName("rec_count");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.SevenCond).HasColumnName("seven_cond");

                entity.Property(e => e.TaakherAmount)
                    .HasColumnType("money")
                    .HasColumnName("taakher_amount");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TotalDays).HasColumnName("total_days");

                entity.Property(e => e.VisaMoney)
                    .HasColumnType("money")
                    .HasColumnName("visa_money");

                entity.Property(e => e.VisaSource)
                    .HasMaxLength(100)
                    .HasColumnName("visa_source");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");

                entity.Property(e => e.Wakeelname)
                    .HasMaxLength(150)
                    .HasColumnName("wakeelname");
            });

            modelBuilder.Entity<RecStatusArrivel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("rec_status_arrivel");

                entity.Property(e => e.Airport)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("airport");

                entity.Property(e => e.ArrivaleDate)
                    .HasColumnType("date")
                    .HasColumnName("arrivale_date");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("country_name");

                entity.Property(e => e.DayTot).HasColumnName("DayTOT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.Insurance).HasColumnName("insurance");

                entity.Property(e => e.Insurancedate)
                    .HasColumnType("date")
                    .HasColumnName("insurancedate");

                entity.Property(e => e.IsArrive).HasColumnName("is_arrive");

                entity.Property(e => e.MuaqpId)
                    .HasMaxLength(50)
                    .HasColumnName("muaqp_id");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("office_name");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.SendDate)
                    .HasMaxLength(50)
                    .HasColumnName("send_date");
            });

            modelBuilder.Entity<RecStatusMsgVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("rec_status_msg_vw");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.DoneDate)
                    .HasColumnType("datetime")
                    .HasColumnName("done_date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDone).HasColumnName("is_done");

                entity.Property(e => e.Job)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.OfficeName)
                    .HasMaxLength(100)
                    .HasColumnName("office_name");

                entity.Property(e => e.Officeid).HasColumnName("officeid");

                entity.Property(e => e.RecName)
                    .HasMaxLength(4000)
                    .HasColumnName("rec_name");

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("s_name");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("date")
                    .HasColumnName("status_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<RecStatusUpVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("rec_status_up_vw");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.DoneDate)
                    .HasColumnType("datetime")
                    .HasColumnName("done_date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IsDone).HasColumnName("is_done");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.RecName)
                    .HasMaxLength(4000)
                    .HasColumnName("rec_name");

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("s_name");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<RecView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RecView");

                entity.Property(e => e.Address)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AqarebAddress)
                    .HasMaxLength(500)
                    .HasColumnName("aqarebAddress");

                entity.Property(e => e.AqarebAddressAr)
                    .HasMaxLength(500)
                    .HasColumnName("aqarebAddress_ar");

                entity.Property(e => e.AqarebselaAr)
                    .HasMaxLength(150)
                    .HasColumnName("aqarebsela_ar");

                entity.Property(e => e.AqarebselaEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("aqarebsela_en");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("bankaccount");

                entity.Property(e => e.BankaddressAr)
                    .HasMaxLength(550)
                    .HasColumnName("bankaddress_ar");

                entity.Property(e => e.BankaddressEn)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("bankaddress_en");

                entity.Property(e => e.BanknameAr)
                    .HasMaxLength(500)
                    .HasColumnName("bankname_ar");

                entity.Property(e => e.BanknameEn)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bankname_en");

                entity.Property(e => e.Courses)
                    .HasMaxLength(150)
                    .HasColumnName("courses");

                entity.Property(e => e.CvFileName)
                    .HasMaxLength(100)
                    .HasColumnName("cv_file_name");

                entity.Property(e => e.Cvno)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cvno");

                entity.Property(e => e.Education)
                    .HasMaxLength(150)
                    .HasColumnName("education");

                entity.Property(e => e.HasExper).HasColumnName("has_exper");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Interview1)
                    .HasMaxLength(20)
                    .HasColumnName("interview1");

                entity.Property(e => e.Interview11)
                    .HasMaxLength(20)
                    .HasColumnName("interview11");

                entity.Property(e => e.Interview12)
                    .HasMaxLength(20)
                    .HasColumnName("interview12");

                entity.Property(e => e.Interview13)
                    .HasMaxLength(20)
                    .HasColumnName("interview13");

                entity.Property(e => e.Interview14)
                    .HasMaxLength(20)
                    .HasColumnName("interview14");

                entity.Property(e => e.Interview15)
                    .HasMaxLength(20)
                    .HasColumnName("interview15");

                entity.Property(e => e.Interview16)
                    .HasMaxLength(20)
                    .HasColumnName("interview16");

                entity.Property(e => e.Interview17)
                    .HasMaxLength(20)
                    .HasColumnName("interview17");

                entity.Property(e => e.Interview18)
                    .HasMaxLength(20)
                    .HasColumnName("interview18");

                entity.Property(e => e.IsBlacklist).HasColumnName("is_blacklist");

                entity.Property(e => e.IsChoosed).HasColumnName("is_choosed");

                entity.Property(e => e.IsDef).HasColumnName("is_def");

                entity.Property(e => e.IsOffical).HasColumnName("is_offical");

                entity.Property(e => e.IsReplace).HasColumnName("is_replace");

                entity.Property(e => e.IsReturn).HasColumnName("is_return");

                entity.Property(e => e.Job)
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.JobEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("job_en");

                entity.Property(e => e.Nameofaqareb)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nameofaqareb");

                entity.Property(e => e.NameofaqarebAr)
                    .HasMaxLength(250)
                    .HasColumnName("nameofaqareb_ar");

                entity.Property(e => e.NationalName)
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.NationalNameEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("national_name_en");

                entity.Property(e => e.OfficePrice)
                    .HasColumnType("money")
                    .HasColumnName("office_price");

                entity.Property(e => e.Passportedate)
                    .HasColumnType("date")
                    .HasColumnName("passportedate");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.Passportplace)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("passportplace");

                entity.Property(e => e.PassportplaceAr)
                    .HasMaxLength(250)
                    .HasColumnName("passportplace_ar");

                entity.Property(e => e.Passportsdate)
                    .HasColumnType("date")
                    .HasColumnName("passportsdate");

                entity.Property(e => e.Personcode)
                    .HasMaxLength(50)
                    .HasColumnName("personcode");

                entity.Property(e => e.Personouside)
                    .HasMaxLength(50)
                    .HasColumnName("personouside");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.PriceUs).HasColumnName("price_us");

                entity.Property(e => e.RecAddressAr)
                    .HasMaxLength(500)
                    .HasColumnName("rec_address_ar");

                entity.Property(e => e.RecMobiile)
                    .HasMaxLength(50)
                    .HasColumnName("rec_mobiile");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.RecNameAr)
                    .HasMaxLength(250)
                    .HasColumnName("rec_name_ar");

                entity.Property(e => e.RecNotes)
                    .HasMaxLength(500)
                    .HasColumnName("rec_notes");

                entity.Property(e => e.RecStatusAr)
                    .HasMaxLength(250)
                    .HasColumnName("rec_status_ar");

                entity.Property(e => e.RecStatusEn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("rec_status_en");

                entity.Property(e => e.Relegion)
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.RelegionEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("relegion_en");

                entity.Property(e => e.Rsa1).HasColumnName("rsa1");

                entity.Property(e => e.Rsa2).HasColumnName("rsa2");

                entity.Property(e => e.Rsa3).HasColumnName("rsa3");

                entity.Property(e => e.Rsa4).HasColumnName("rsa4");

                entity.Property(e => e.Rsa5).HasColumnName("rsa5");

                entity.Property(e => e.Rsa6).HasColumnName("rsa6");

                entity.Property(e => e.Rsa7).HasColumnName("rsa7");

                entity.Property(e => e.SelectedDate)
                    .HasColumnType("date")
                    .HasColumnName("selected_date");

                entity.Property(e => e.SendDate)
                    .HasMaxLength(50)
                    .HasColumnName("send_date");

                entity.Property(e => e.Strimg).HasColumnName("STRIMG");

                entity.Property(e => e.TransmitId).HasColumnName("transmit_id");

                entity.Property(e => e.University)
                    .HasMaxLength(150)
                    .HasColumnName("university");

                entity.Property(e => e.WedCk).HasColumnName("WedCK");
            });

            modelBuilder.Entity<Receiptpaymentview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("receiptpaymentview");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Notce)
                    .HasMaxLength(300)
                    .HasColumnName("notce");

                entity.Property(e => e.PayNotce)
                    .HasMaxLength(300)
                    .HasColumnName("pay_notce");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date");
            });

            modelBuilder.Entity<RecruitmenterStatusVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("recruitmenter_status_vw");

                entity.Property(e => e.Airport)
                    .HasMaxLength(4000)
                    .HasColumnName("airport");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.DoneDate)
                    .HasColumnType("datetime")
                    .HasColumnName("done_date");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IsDone).HasColumnName("is_done");

                entity.Property(e => e.MuaqpId).HasColumnName("muaqp_id");

                entity.Property(e => e.OfficeTbl).HasColumnName("office_tbl");

                entity.Property(e => e.Passportno)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("passportno");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.RecName)
                    .HasMaxLength(4000)
                    .HasColumnName("rec_name");

                entity.Property(e => e.RecNotes)
                    .HasMaxLength(4000)
                    .HasColumnName("rec_notes");

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("s_name");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("date")
                    .HasColumnName("status_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<RecruitmenterTa3jeerTbl>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("recruitmenter_ta3jeer_tbl");

                entity.HasIndex(e => e.RecId, "recruitmenter_ta3jeer_tbl_id")
                    .IsUnique();

                entity.Property(e => e.RecId)
                    .ValueGeneratedNever()
                    .HasColumnName("rec_id");

                entity.Property(e => e.CostDiscrp)
                    .HasMaxLength(550)
                    .HasColumnName("cost_discrp");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.InsuranceEndDate)
                    .HasColumnType("date")
                    .HasColumnName("insurance_end_date");

                entity.Property(e => e.IqamaEndDate)
                    .HasColumnType("date")
                    .HasColumnName("iqama_end_date");

                entity.Property(e => e.IqamaNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("iqama_num");

                entity.Property(e => e.IsExit).HasColumnName("is_exit");

                entity.Property(e => e.IsKafala).HasColumnName("is_kafala");

                entity.Property(e => e.KafalaDate)
                    .HasColumnType("date")
                    .HasColumnName("kafala_date");

                entity.Property(e => e.Mo3hlatkhbrat)
                    .HasMaxLength(250)
                    .HasColumnName("mo3hlatkhbrat");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PassportEndDate)
                    .HasColumnType("date")
                    .HasColumnName("passport_end_date");

                entity.Property(e => e.RecCost)
                    .HasColumnType("money")
                    .HasColumnName("rec_cost");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(50)
                    .HasColumnName("rec_status");

                entity.HasOne(d => d.Rec)
                    .WithOne(p => p.RecruitmenterTa3jeerTbl)
                    .HasForeignKey<RecruitmenterTa3jeerTbl>(d => d.RecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_recruitmenter_ta3jeer_tbl_recruitmenter_tbl");
            });

            modelBuilder.Entity<RecruitmenterTbl>(entity =>
            {
                entity.ToTable("recruitmenter_tbl");

                entity.HasIndex(e => e.Passportno, "Uniquepassportno")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AqarebAddress)
                    .HasMaxLength(500)
                    .HasColumnName("aqarebAddress");

                entity.Property(e => e.AqarebAddressAr)
                    .HasMaxLength(500)
                    .HasColumnName("aqarebAddress_ar");

                entity.Property(e => e.AqarebselaAr)
                    .HasMaxLength(150)
                    .HasColumnName("aqarebsela_ar");

                entity.Property(e => e.AqarebselaEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("aqarebsela_en");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("bankaccount");

                entity.Property(e => e.BankaddressAr)
                    .HasMaxLength(550)
                    .HasColumnName("bankaddress_ar");

                entity.Property(e => e.BankaddressEn)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("bankaddress_en");

                entity.Property(e => e.BanknameAr)
                    .HasMaxLength(500)
                    .HasColumnName("bankname_ar");

                entity.Property(e => e.BanknameEn)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bankname_en");

                entity.Property(e => e.Courses)
                    .HasMaxLength(150)
                    .HasColumnName("courses");

                entity.Property(e => e.CvFileName)
                    .HasMaxLength(100)
                    .HasColumnName("cv_file_name");

                entity.Property(e => e.Cvno)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cvno");

                entity.Property(e => e.Education)
                    .HasMaxLength(150)
                    .HasColumnName("education");

                entity.Property(e => e.HasExper)
                    .HasColumnName("has_exper")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Interview1)
                    .HasMaxLength(20)
                    .HasColumnName("interview1");

                entity.Property(e => e.Interview11)
                    .HasMaxLength(20)
                    .HasColumnName("interview11");

                entity.Property(e => e.Interview12)
                    .HasMaxLength(20)
                    .HasColumnName("interview12");

                entity.Property(e => e.Interview13)
                    .HasMaxLength(20)
                    .HasColumnName("interview13");

                entity.Property(e => e.Interview14)
                    .HasMaxLength(20)
                    .HasColumnName("interview14");

                entity.Property(e => e.Interview15)
                    .HasMaxLength(20)
                    .HasColumnName("interview15");

                entity.Property(e => e.Interview16)
                    .HasMaxLength(20)
                    .HasColumnName("interview16");

                entity.Property(e => e.Interview17)
                    .HasMaxLength(20)
                    .HasColumnName("interview17");

                entity.Property(e => e.Interview18).HasColumnName("interview18");

                entity.Property(e => e.IsBlacklist).HasColumnName("is_blacklist");

                entity.Property(e => e.IsChoosed).HasColumnName("is_choosed");

                entity.Property(e => e.IsDef)
                    .HasColumnName("is_def")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOffical)
                    .HasColumnName("is_offical")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsReplace)
                    .HasColumnName("is_replace")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReturn)
                    .HasColumnName("is_return")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Nameofaqareb)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nameofaqareb");

                entity.Property(e => e.NameofaqarebAr)
                    .HasMaxLength(250)
                    .HasColumnName("nameofaqareb_ar");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.OfficePrice)
                    .HasColumnType("money")
                    .HasColumnName("office_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OfficeTbl).HasColumnName("office_tbl");

                entity.Property(e => e.Passportedate)
                    .HasColumnType("date")
                    .HasColumnName("passportedate");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.Passportplace)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("passportplace");

                entity.Property(e => e.PassportplaceAr)
                    .HasMaxLength(250)
                    .HasColumnName("passportplace_ar");

                entity.Property(e => e.Passportsdate)
                    .HasColumnType("date")
                    .HasColumnName("passportsdate");

                entity.Property(e => e.Personcode)
                    .HasMaxLength(50)
                    .HasColumnName("personcode");

                entity.Property(e => e.Personouside)
                    .HasMaxLength(50)
                    .HasColumnName("personouside");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.PriceUs).HasColumnName("price_us");

                entity.Property(e => e.RecAddressAr)
                    .HasMaxLength(500)
                    .HasColumnName("rec_address_ar");

                entity.Property(e => e.RecMobiile)
                    .HasMaxLength(50)
                    .HasColumnName("rec_mobiile");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.RecNameAr)
                    .HasMaxLength(250)
                    .HasColumnName("rec_name_ar");

                entity.Property(e => e.RecNotes)
                    .HasMaxLength(500)
                    .HasColumnName("rec_notes");

                entity.Property(e => e.RecStatusAr)
                    .HasMaxLength(250)
                    .HasColumnName("rec_status_ar");

                entity.Property(e => e.RecStatusEn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("rec_status_en");

                entity.Property(e => e.RelegionId).HasColumnName("relegion_id");

                entity.Property(e => e.Rsa1).HasColumnName("rsa1");

                entity.Property(e => e.Rsa2).HasColumnName("rsa2");

                entity.Property(e => e.Rsa3).HasColumnName("rsa3");

                entity.Property(e => e.Rsa4).HasColumnName("rsa4");

                entity.Property(e => e.Rsa5).HasColumnName("rsa5");

                entity.Property(e => e.Rsa6).HasColumnName("rsa6");

                entity.Property(e => e.Rsa7).HasColumnName("rsa7");

                entity.Property(e => e.SelectedDate)
                    .HasColumnType("date")
                    .HasColumnName("selected_date");

                entity.Property(e => e.SendDate)
                    .HasMaxLength(50)
                    .HasColumnName("send_date");

                entity.Property(e => e.Strimg).HasColumnName("STRIMG");

                entity.Property(e => e.TransmitId)
                    .HasColumnName("transmit_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.University)
                    .HasMaxLength(150)
                    .HasColumnName("university");

                entity.Property(e => e.WedCk).HasColumnName("WedCK");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.RecruitmenterTbls)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_recruitmenter_tbl_job_tbl");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.RecruitmenterTbls)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_recruitmenter_tbl_nationality_tbl");

                entity.HasOne(d => d.OfficeTblNavigation)
                    .WithMany(p => p.RecruitmenterTbls)
                    .HasForeignKey(d => d.OfficeTbl)
                    .HasConstraintName("FK_recruitmenter_tbl_office_tbl");

                entity.HasOne(d => d.Relegion)
                    .WithMany(p => p.RecruitmenterTbls)
                    .HasForeignKey(d => d.RelegionId)
                    .HasConstraintName("FK_recruitmenter_tbl_relegion_tbl");
            });

            modelBuilder.Entity<RelegionTbl>(entity =>
            {
                entity.ToTable("relegion_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Relegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("relegion");

                entity.Property(e => e.RelegionEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("relegion_en");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("reports");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastupdate");

                entity.Property(e => e.RContent)
                    .HasColumnType("ntext")
                    .HasColumnName("r_content");

                entity.Property(e => e.Reportfile).HasColumnName("reportfile");

                entity.Property(e => e.UniqeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uniqeName");

                entity.Property(e => e.Userupdate).HasColumnName("userupdate");
            });

            modelBuilder.Entity<ReturnReplaceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("return_replace_view");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.Arrdate)
                    .HasColumnType("date")
                    .HasColumnName("arrdate");

                entity.Property(e => e.Arrretdate)
                    .HasColumnType("date")
                    .HasColumnName("arrretdate");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsReplace).HasColumnName("is_replace");

                entity.Property(e => e.IsReturn).HasColumnName("is_return");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.RecNotes)
                    .HasMaxLength(500)
                    .HasColumnName("rec_notes");

                entity.Property(e => e.Visadate)
                    .HasColumnType("date")
                    .HasColumnName("visadate");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<SanadPrintSetting>(entity =>
            {
                entity.ToTable("sanad_print_settings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FieldBind)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("field_bind");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("field_name")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hight).HasColumnName("hight");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.Xc).HasColumnName("xc");

                entity.Property(e => e.Yc).HasColumnName("yc");
            });

            modelBuilder.Entity<SearchStView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SearchStView");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.Cvno)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cvno");

                entity.Property(e => e.DoneDate)
                    .HasColumnType("datetime")
                    .HasColumnName("done_date");

                entity.Property(e => e.IsDone).HasColumnName("is_done");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.SName)
                    .HasMaxLength(150)
                    .HasColumnName("s_name");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("date")
                    .HasColumnName("status_date");
            });

            modelBuilder.Entity<ServicesTypesTbl>(entity =>
            {
                entity.ToTable("services_types_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ServiceName).HasColumnName("service_name");
            });

            modelBuilder.Entity<SmsSendVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sms_send_vw");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NationalNameEn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("national_name_en");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<SolafPaymentTbl>(entity =>
            {
                entity.ToTable("solaf_payment_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.PayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pay_date");

                entity.Property(e => e.SalId).HasColumnName("sal_id");

                entity.Property(e => e.SolfaId).HasColumnName("solfa_id");
            });

            modelBuilder.Entity<SolafTbl>(entity =>
            {
                entity.ToTable("solaf_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasColumnName("balance");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(3000)
                    .HasColumnName("notes");

                entity.Property(e => e.Permonth)
                    .HasColumnType("money")
                    .HasColumnName("permonth");

                entity.Property(e => e.SDate)
                    .HasColumnType("date")
                    .HasColumnName("s_date");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.SolafTbls)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_solaf_tbl_account");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.SolafTbls)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_solaf_tbl_employee_tbl");
            });

            modelBuilder.Entity<SrvServicesTbl>(entity =>
            {
                entity.ToTable("srv_services_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attachment1).HasColumnName("attachment1");

                entity.Property(e => e.Attachment2).HasColumnName("attachment2");

                entity.Property(e => e.BillCostId).HasColumnName("BillCostID");

                entity.Property(e => e.BillCurnceyId).HasColumnName("BillCurnceyID");

                entity.Property(e => e.BillDeleteId).HasColumnName("BillDeleteID");

                entity.Property(e => e.BillMainId).HasColumnName("BillMainID");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsEndDate)
                    .HasColumnType("date")
                    .HasColumnName("is_end_date");

                entity.Property(e => e.IsNew).HasColumnName("is_new");

                entity.Property(e => e.IsNewDate)
                    .HasColumnType("date")
                    .HasColumnName("is_new_date");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.IsSendDate)
                    .HasColumnType("date")
                    .HasColumnName("is_send_date");

                entity.Property(e => e.IsSendToMouqeb).HasColumnName("is_send_to_mouqeb");

                entity.Property(e => e.IsUnderProcess).HasColumnName("is_under_process");

                entity.Property(e => e.IsUnderProcessDate)
                    .HasColumnType("date")
                    .HasColumnName("is_under_process_date");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("return_date");

                entity.Property(e => e.SrvAmount)
                    .HasColumnType("money")
                    .HasColumnName("srv_amount");

                entity.Property(e => e.SrvDate)
                    .HasColumnType("date")
                    .HasColumnName("srv_date");

                entity.Property(e => e.SrvDuration).HasColumnName("srv_duration");

                entity.Property(e => e.SrvMouqeb1).HasColumnName("srv_mouqeb1");

                entity.Property(e => e.SrvMouqeb2).HasColumnName("srv_mouqeb2");

                entity.Property(e => e.SrvMouqebPrice)
                    .HasColumnType("money")
                    .HasColumnName("srv_mouqeb_price");

                entity.Property(e => e.SrvMouqebPrice2)
                    .HasColumnType("money")
                    .HasColumnName("srv_mouqeb_price2");

                entity.Property(e => e.SrvTax).HasColumnName("srv_tax");

                entity.Property(e => e.SvrDiscription).HasColumnName("svr_discription");

                entity.Property(e => e.Usrname).HasColumnName("usrname");

                entity.Property(e => e.YearClose).HasColumnName("year_close");

                entity.Property(e => e.YearId).HasColumnName("year_id");

                entity.Property(e => e.YearIdRet).HasColumnName("year_id_ret");
            });

            modelBuilder.Entity<StatusNameTbl>(entity =>
            {
                entity.ToTable("status_name_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AfterSend).HasColumnName("after_send");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("s_name");

                entity.Property(e => e.SNameEn)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("s_name_en");

                entity.Property(e => e.SOrder).HasColumnName("s_order");

                entity.Property(e => e.TotalDays).HasColumnName("total_days");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StatusNameTbls)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_status_name_tbl_nationality_tbl");
            });

            modelBuilder.Entity<StatusTbl>(entity =>
            {
                entity.ToTable("status_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoneDate)
                    .HasColumnType("datetime")
                    .HasColumnName("done_date");

                entity.Property(e => e.IsDone).HasColumnName("is_done");

                entity.Property(e => e.IsUp).HasColumnName("is_up");

                entity.Property(e => e.Notice).HasColumnName("notice");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("date")
                    .HasColumnName("status_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.StatusTbls)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_status_tbl_status_name_tbl");
            });

            modelBuilder.Entity<StatusView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StatusView");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.AqedSource).HasColumnName("aqed_source");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.ChvisaDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chvisa_date");

                entity.Property(e => e.Ckarrivel).HasColumnName("CKArrivel");

                entity.Property(e => e.Ckstat).HasColumnName("CKStat");

                entity.Property(e => e.Ckticket).HasColumnName("CKTicket");

                entity.Property(e => e.CkticketDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CKTicket_date");

                entity.Property(e => e.Ckvisa).HasColumnName("CKVisa");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("country_name");

                entity.Property(e => e.FourteenCond)
                    .HasMaxLength(4000)
                    .HasColumnName("fourteen_cond");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdDateofbirth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_dateofbirth");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IsAqed).HasColumnName("is_aqed");

                entity.Property(e => e.IsDefined).HasColumnName("is_defined");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsEnd).HasColumnName("is_end");

                entity.Property(e => e.IsNone).HasColumnName("is_none");

                entity.Property(e => e.IsPayedForVisa).HasColumnName("is_payed_for_visa");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.IsVip).HasColumnName("is_vip");

                entity.Property(e => e.IsWakeel).HasColumnName("is_wakeel");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.Officename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("officename");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(4000)
                    .HasColumnName("passportno");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.RecName)
                    .HasMaxLength(4000)
                    .HasColumnName("rec_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<TableMap>(entity =>
            {
                entity.HasKey(e => e.EnTableName);

                entity.ToTable("TableMap");

                entity.Property(e => e.EnTableName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("en_table_name");

                entity.Property(e => e.ArTableName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("ar_table_name");
            });

            modelBuilder.Entity<TajeerkafalaVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tajeerkafala_vw");

                entity.Property(e => e.CName)
                    .HasMaxLength(300)
                    .HasColumnName("c_name");

                entity.Property(e => e.HandDate)
                    .HasColumnType("date")
                    .HasColumnName("hand_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Indum)
                    .HasMaxLength(300)
                    .HasColumnName("indum");

                entity.Property(e => e.NationalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("national_name");

                entity.Property(e => e.Newcust)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("newcust");

                entity.Property(e => e.Newidcust)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("newidcust");

                entity.Property(e => e.Newmobcust)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("newmobcust");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.Phone)
                    .HasMaxLength(300)
                    .HasColumnName("phone");

                entity.Property(e => e.Renacme)
                    .HasMaxLength(200)
                    .HasColumnName("renacme");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasColumnName("total_amount");
            });

            modelBuilder.Entity<TaxToTview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TaxToTView");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.CName).HasColumnName("c_name");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.CostId).HasColumnName("CostID");

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.DisCountVl).HasColumnName("DisCountVL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.IsReturned).HasColumnName("is_returned");

                entity.Property(e => e.Job).HasColumnName("job");

                entity.Property(e => e.NationalName).HasColumnName("national_name");

                entity.Property(e => e.OfficeName)
                    .HasMaxLength(100)
                    .HasColumnName("office_name");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.Tot1).HasColumnName("TOT1");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TotwithTax).HasColumnName("TOTWithTax");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.VisaIsOur).HasColumnName("visa_is_our");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<Taxview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("taxview");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("account_name");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.AqedId).HasColumnName("aqed_id");

                entity.Property(e => e.CName)
                    .HasMaxLength(150)
                    .HasColumnName("c_name");

                entity.Property(e => e.Finalamount)
                    .HasColumnType("money")
                    .HasColumnName("finalamount");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Notce).HasColumnName("notce");

                entity.Property(e => e.PayNotce)
                    .HasMaxLength(300)
                    .HasColumnName("pay_notce");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date");

                entity.Property(e => e.PaymentType).HasColumnName("payment_type");

                entity.Property(e => e.Taxamount)
                    .HasColumnType("money")
                    .HasColumnName("taxamount");

                entity.Property(e => e.Taxvalue)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("taxvalue");

                entity.Property(e => e.Withouttax).HasColumnName("withouttax");
            });

            modelBuilder.Entity<Tblabout>(entity =>
            {
                entity.HasKey(e => e.Abid);

                entity.ToTable("TBLAbout");

                entity.Property(e => e.Abid).HasColumnName("ABID");

                entity.Property(e => e.Abaders).HasColumnName("ABAders");

                entity.Property(e => e.Abadres1).HasColumnName("ABAdres1");

                entity.Property(e => e.Abadres2).HasColumnName("ABAdres2");

                entity.Property(e => e.Abadres3).HasColumnName("ABAdres3");

                entity.Property(e => e.Abimg1).HasColumnName("ABIMG1");

                entity.Property(e => e.Abimg2).HasColumnName("ABIMG2");

                entity.Property(e => e.Abimg3).HasColumnName("ABIMG3");

                entity.Property(e => e.Abtxt).HasColumnName("ABTXT");

                entity.Property(e => e.Abtxt1).HasColumnName("ABTXT1");

                entity.Property(e => e.Abtxt2).HasColumnName("ABTXT2");

                entity.Property(e => e.Abtxt3).HasColumnName("ABTXT3");
            });

            modelBuilder.Entity<Tblacount>(entity =>
            {
                entity.HasKey(e => e.AcountId);

                entity.ToTable("TBLAcount");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AccountCode).HasMaxLength(150);

                entity.Property(e => e.AccountMd).HasColumnName("AccountMD");

                entity.Property(e => e.AcountName).HasMaxLength(250);

                entity.Property(e => e.Lev1).HasColumnName("lev1");

                entity.Property(e => e.Lev2).HasColumnName("lev2");

                entity.Property(e => e.Lev3).HasColumnName("lev3");

                entity.Property(e => e.Lev4).HasColumnName("lev4");

                entity.Property(e => e.Lev5).HasColumnName("lev5");
            });

            modelBuilder.Entity<Tblanlay>(entity =>
            {
                entity.HasKey(e => e.Anlid);

                entity.ToTable("TBLAnlays");

                entity.Property(e => e.Anlid).HasColumnName("ANLID");

                entity.Property(e => e.Anltot1)
                    .HasMaxLength(50)
                    .HasColumnName("ANLTOT1");

                entity.Property(e => e.Anltot2)
                    .HasMaxLength(50)
                    .HasColumnName("ANLTOT2");

                entity.Property(e => e.Anltot3)
                    .HasMaxLength(50)
                    .HasColumnName("ANLTOT3");

                entity.Property(e => e.Anltot4)
                    .HasMaxLength(50)
                    .HasColumnName("ANLTOT4");

                entity.Property(e => e.Anltxt).HasColumnName("ANLTXT");

                entity.Property(e => e.Anltxt1)
                    .HasMaxLength(50)
                    .HasColumnName("ANLTXT1");

                entity.Property(e => e.Anltxt2)
                    .HasMaxLength(50)
                    .HasColumnName("ANLTXT2");

                entity.Property(e => e.Anltxt3)
                    .HasMaxLength(50)
                    .HasColumnName("ANLTXT3");

                entity.Property(e => e.Anltxt4)
                    .HasMaxLength(50)
                    .HasColumnName("ANLTXT4");
            });

            modelBuilder.Entity<TblappWin>(entity =>
            {
                entity.HasKey(e => e.Appid);

                entity.ToTable("TBLAppWin");

                entity.Property(e => e.Appid).HasColumnName("APPID");

                entity.Property(e => e.Appaderss).HasColumnName("APPAderss");

                entity.Property(e => e.Appimg1).HasColumnName("APPIMG1");

                entity.Property(e => e.Appimg2).HasColumnName("APPIMG2");

                entity.Property(e => e.Appimg3).HasColumnName("APPIMG3");

                entity.Property(e => e.Appimg4).HasColumnName("APPIMG4");

                entity.Property(e => e.Appimg5).HasColumnName("APPIMG5");

                entity.Property(e => e.Applink).HasColumnName("APPLink");

                entity.Property(e => e.Apptitel).HasColumnName("APPTitel");

                entity.Property(e => e.Apptxt).HasColumnName("APPTXT");
            });

            modelBuilder.Entity<TblbillAcc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLBillAcc");

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillCostId).HasColumnName("BillCostID");

                entity.Property(e => e.BillCurnceyId).HasColumnName("BillCurnceyID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillOutvalue).HasColumnName("BillOUTValue");

                entity.Property(e => e.BillType).HasMaxLength(50);

                entity.Property(e => e.MainBillId).HasColumnName("MainBillID");

                entity.Property(e => e.YearClose).HasColumnName("year_close");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<TblbillAccHd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLBillAccHD");

                entity.Property(e => e.BillHeaderCostId).HasColumnName("BillHeaderCostID");

                entity.Property(e => e.BillHeaderCurnceyId).HasColumnName("BillHeaderCurnceyID");

                entity.Property(e => e.BillHeaderDate).HasColumnType("date");

                entity.Property(e => e.BillHeaderId).HasColumnName("BillHeaderID");

                entity.Property(e => e.BillHeaderTybeId).HasColumnName("BillHeaderTybeID");

                entity.Property(e => e.YearClose).HasColumnName("year_close");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<TblbillHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLBillHeader");

                entity.Property(e => e.BillHeaderCostId).HasColumnName("BillHeaderCostID");

                entity.Property(e => e.BillHeaderCurnceyId).HasColumnName("BillHeaderCurnceyID");

                entity.Property(e => e.BillHeaderDate).HasColumnType("date");

                entity.Property(e => e.BillHeaderId).HasColumnName("BillHeaderID");

                entity.Property(e => e.BillHeaderTybeId).HasColumnName("BillHeaderTybeID");

                entity.Property(e => e.YearClose).HasColumnName("year_close");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<TblbillsIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLBillsIN");

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillAcTo).HasColumnName("BillAcTO");

                entity.Property(e => e.BillCostId).HasColumnName("BillCostID");

                entity.Property(e => e.BillCurnceyId).HasColumnName("BillCurnceyID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillType).HasMaxLength(50);

                entity.Property(e => e.BillTypeDt)
                    .HasColumnType("date")
                    .HasColumnName("BillTypeDT");

                entity.Property(e => e.BillTypeId)
                    .HasMaxLength(150)
                    .HasColumnName("BillTypeID");

                entity.Property(e => e.FaturaType)
                    .HasMaxLength(150)
                    .HasColumnName("fatura_type");

                entity.Property(e => e.IsFatura).HasColumnName("is_fatura");

                entity.Property(e => e.MainBillId).HasColumnName("MainBillID");

                entity.Property(e => e.SadadType).HasColumnName("sadad_type");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.Taxamount)
                    .HasColumnType("money")
                    .HasColumnName("taxamount");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.Withouttax).HasColumnName("withouttax");

                entity.Property(e => e.YearClose).HasColumnName("year_close");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<TblbillsOut>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLBillsOUT");

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillAcTo).HasColumnName("BillAcTO");

                entity.Property(e => e.BillCostId).HasColumnName("BillCostID");

                entity.Property(e => e.BillCurnceyId).HasColumnName("BillCurnceyID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillType).HasMaxLength(50);

                entity.Property(e => e.BillTypeDt)
                    .HasColumnType("date")
                    .HasColumnName("BillTypeDT");

                entity.Property(e => e.BillTypeId)
                    .HasMaxLength(150)
                    .HasColumnName("BillTypeID");

                entity.Property(e => e.FaturaType)
                    .HasMaxLength(150)
                    .HasColumnName("fatura_type");

                entity.Property(e => e.IsFatura).HasColumnName("is_fatura");

                entity.Property(e => e.MainBillId).HasColumnName("MainBillID");

                entity.Property(e => e.SadadType).HasColumnName("sadad_type");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.Taxamount)
                    .HasColumnType("money")
                    .HasColumnName("taxamount");

                entity.Property(e => e.Taxval).HasColumnName("taxval");

                entity.Property(e => e.Withouttax).HasColumnName("withouttax");

                entity.Property(e => e.YearClose).HasColumnName("year_close");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<Tblcompany>(entity =>
            {
                entity.HasKey(e => e.Comid)
                    .HasName("PK_TBLCompany_1");

                entity.ToTable("TBLCompany");

                entity.Property(e => e.Comid).HasColumnName("COMID");

                entity.Property(e => e.Comemail).HasColumnName("COMEmail");

                entity.Property(e => e.ComfaceBook).HasColumnName("COMFaceBook");

                entity.Property(e => e.Comfax).HasColumnName("COMFax");

                entity.Property(e => e.Cominstgram).HasColumnName("COMInstgram");

                entity.Property(e => e.Comlat).HasColumnName("COMLat");

                entity.Property(e => e.Comline).HasColumnName("COMLine");

                entity.Property(e => e.Comlocation).HasColumnName("COMLocation");

                entity.Property(e => e.Comlong).HasColumnName("COMLong");

                entity.Property(e => e.Comname).HasColumnName("COMName");

                entity.Property(e => e.Comphone).HasColumnName("COMPhone");

                entity.Property(e => e.Comtwitter).HasColumnName("COMTwitter");

                entity.Property(e => e.Comyoutube).HasColumnName("COMYoutube");
            });

            modelBuilder.Entity<Tblconu>(entity =>
            {
                entity.HasKey(e => e.Cnid);

                entity.ToTable("TBLCONUS");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.Cnadress).HasColumnName("CNAdress");

                entity.Property(e => e.Cnemail).HasColumnName("CNEmail");

                entity.Property(e => e.Cnmobile).HasColumnName("CNMobile");

                entity.Property(e => e.Cntxt).HasColumnName("CNTXT");
            });

            modelBuilder.Entity<TblcostCenter>(entity =>
            {
                entity.ToTable("TBLCostCenter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.CostCenterNameEn)
                    .HasMaxLength(100)
                    .HasColumnName("CostCenterNameEN");
            });

            modelBuilder.Entity<Tblcurrncey>(entity =>
            {
                entity.HasKey(e => e.Crid);

                entity.ToTable("TBLCurrncey");

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.CunameEn).HasColumnName("CUNameEN");

                entity.Property(e => e.Cushort)
                    .HasMaxLength(50)
                    .HasColumnName("CUShort");
            });

            modelBuilder.Entity<TblcusInformation>(entity =>
            {
                entity.ToTable("TBLCusInformation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CusNumId)
                    .HasMaxLength(50)
                    .HasColumnName("CusNumID");

                entity.Property(e => e.CusTxt)
                    .HasMaxLength(50)
                    .HasColumnName("CusTXT");

                entity.Property(e => e.Dt)
                    .HasColumnType("datetime")
                    .HasColumnName("DT");

                entity.Property(e => e.Gtactive).HasColumnName("GTActive");

                entity.Property(e => e.Gtok).HasColumnName("GTOK");

                entity.Property(e => e.RecId).HasColumnName("RecID");
            });

            modelBuilder.Entity<Tblendacount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLENDAcount");

                entity.Property(e => e.Endid).HasColumnName("ENDID");

                entity.Property(e => e.Endname)
                    .HasMaxLength(50)
                    .HasColumnName("ENDName");
            });

            modelBuilder.Entity<Tblfooter>(entity =>
            {
                entity.HasKey(e => e.Fotid);

                entity.ToTable("TBLFooter");

                entity.Property(e => e.Fotid).HasColumnName("FOTID");

                entity.Property(e => e.Foadress1).HasColumnName("FOAdress1");

                entity.Property(e => e.Foadress2).HasColumnName("FOAdress2");

                entity.Property(e => e.Foemail).HasColumnName("FOEmail");

                entity.Property(e => e.Fofc).HasColumnName("FOFC");

                entity.Property(e => e.Fogoole).HasColumnName("FOGoole");

                entity.Property(e => e.Foin).HasColumnName("FOIN");

                entity.Property(e => e.Foinstg).HasColumnName("FOInstg");

                entity.Property(e => e.Fomobile1).HasColumnName("FOMobile1");

                entity.Property(e => e.Fomobile2).HasColumnName("FOMobile2");

                entity.Property(e => e.FotTxt).HasColumnName("FOtTXT");

                entity.Property(e => e.Fotwter).HasColumnName("FOTwter");
            });

            modelBuilder.Entity<Tblgetprice>(entity =>
            {
                entity.HasKey(e => e.Gtid);

                entity.ToTable("TBLGETPrice");

                entity.Property(e => e.Gtid).HasColumnName("GTID");

                entity.Property(e => e.Gtactive).HasColumnName("GTActive");

                entity.Property(e => e.Gtcard).HasColumnName("GTCard");

                entity.Property(e => e.GtdominCk).HasColumnName("GTDominCK");

                entity.Property(e => e.GtdominLast).HasColumnName("GTDominLast");

                entity.Property(e => e.GtdominName).HasColumnName("GTDominName");

                entity.Property(e => e.Gtdt)
                    .HasColumnType("datetime")
                    .HasColumnName("GTDT");

                entity.Property(e => e.Gtemail).HasColumnName("GTEmail");

                entity.Property(e => e.Gtmobile).HasColumnName("GTMobile");

                entity.Property(e => e.Gtname).HasColumnName("GTName");

                entity.Property(e => e.Gtok).HasColumnName("GTOK");

                entity.Property(e => e.Gtprice).HasColumnName("GTPrice");

                entity.Property(e => e.GtuserIp).HasColumnName("GTUserIP");
            });

            modelBuilder.Entity<Tblinvoice>(entity =>
            {
                entity.HasKey(e => e.Inid);

                entity.ToTable("TBLInvoice");

                entity.Property(e => e.Inid).HasColumnName("INID");

                entity.Property(e => e.Inactive).HasColumnName("INActive");

                entity.Property(e => e.Indate)
                    .HasColumnType("datetime")
                    .HasColumnName("INDate");

                entity.Property(e => e.Indis).HasColumnName("INDis");

                entity.Property(e => e.Inkind).HasColumnName("INKind");

                entity.Property(e => e.Inleft).HasColumnName("INLeft");

                entity.Property(e => e.Inname).HasColumnName("INName");

                entity.Property(e => e.Innotice).HasColumnName("INNotice");

                entity.Property(e => e.Inprice).HasColumnName("INPrice");

                entity.Property(e => e.Intotal).HasColumnName("INTotal");

                entity.Property(e => e.Intype)
                    .HasMaxLength(50)
                    .HasColumnName("INType");
            });

            modelBuilder.Entity<TblmainBill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLMainBill");

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillAccId).HasColumnName("BillAccID");

                entity.Property(e => e.BillCostId).HasColumnName("BillCostID");

                entity.Property(e => e.BillCurnceyId).HasColumnName("BillCurnceyID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillOutvalue).HasColumnName("BillOUTValue");

                entity.Property(e => e.PNotice)
                    .HasMaxLength(50)
                    .HasColumnName("p_notice");

                entity.Property(e => e.SubBillId).HasColumnName("SubBillID");

                entity.Property(e => e.YearClose).HasColumnName("year_close");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<Tblmessege>(entity =>
            {
                entity.ToTable("TBLMessege");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Emdt)
                    .HasColumnType("datetime")
                    .HasColumnName("EMDT");

                entity.Property(e => e.Ememail).HasColumnName("EMEmail");

                entity.Property(e => e.Emmsg).HasColumnName("EMMsg");

                entity.Property(e => e.Emname).HasColumnName("EMName");

                entity.Property(e => e.Emread).HasColumnName("EMRead");

                entity.Property(e => e.EmreadDt)
                    .HasColumnType("datetime")
                    .HasColumnName("EMReadDT");

                entity.Property(e => e.Emsubject).HasColumnName("EMSubject");
            });

            modelBuilder.Entity<TblourWork>(entity =>
            {
                entity.HasKey(e => e.Ourid);

                entity.ToTable("TBLOurWork");

                entity.Property(e => e.Ourid).HasColumnName("OURID");

                entity.Property(e => e.Ouradrs1).HasColumnName("OURAdrs1");

                entity.Property(e => e.Ouradrs2).HasColumnName("OURAdrs2");

                entity.Property(e => e.Ouradrs3).HasColumnName("OURAdrs3");

                entity.Property(e => e.Ouradrs4).HasColumnName("OURAdrs4");

                entity.Property(e => e.Ouradrs5).HasColumnName("OURAdrs5");

                entity.Property(e => e.Ouradrs6).HasColumnName("OURAdrs6");

                entity.Property(e => e.Ouradrs7).HasColumnName("OURAdrs7");

                entity.Property(e => e.Ouradrs8).HasColumnName("OURAdrs8");

                entity.Property(e => e.Ouradrs9).HasColumnName("OURAdrs9");

                entity.Property(e => e.Ourilink1).HasColumnName("OURILink1");

                entity.Property(e => e.Ourilink2).HasColumnName("OURILink2");

                entity.Property(e => e.Ourilink3).HasColumnName("OURILink3");

                entity.Property(e => e.Ourilink4).HasColumnName("OURILink4");

                entity.Property(e => e.Ourilink5).HasColumnName("OURILink5");

                entity.Property(e => e.Ourilink6).HasColumnName("OURILink6");

                entity.Property(e => e.Ourilink7).HasColumnName("OURILink7");

                entity.Property(e => e.Ourilink8).HasColumnName("OURILink8");

                entity.Property(e => e.Ourilink9).HasColumnName("OURILink9");

                entity.Property(e => e.Ourimg1).HasColumnName("OURIMG1");

                entity.Property(e => e.Ourimg2).HasColumnName("OURIMG2");

                entity.Property(e => e.Ourimg3).HasColumnName("OURIMG3");

                entity.Property(e => e.Ourimg4).HasColumnName("OURIMG4");

                entity.Property(e => e.Ourimg5).HasColumnName("OURIMG5");

                entity.Property(e => e.Ourimg6).HasColumnName("OURIMG6");

                entity.Property(e => e.Ourimg7).HasColumnName("OURIMG7");

                entity.Property(e => e.Ourimg8).HasColumnName("OURIMG8");

                entity.Property(e => e.Ourimg9).HasColumnName("OURIMG9");

                entity.Property(e => e.Ourtxt1).HasColumnName("OURTXT1");

                entity.Property(e => e.Ourtxt2).HasColumnName("OURTXT2");

                entity.Property(e => e.Ourtxt3).HasColumnName("OURTXT3");

                entity.Property(e => e.Ourtxt4).HasColumnName("OURTXT4");

                entity.Property(e => e.Ourtxt5).HasColumnName("OURTXT5");

                entity.Property(e => e.Ourtxt6).HasColumnName("OURTXT6");

                entity.Property(e => e.Ourtxt7).HasColumnName("OURTXT7");

                entity.Property(e => e.Ourtxt8).HasColumnName("OURTXT8");

                entity.Property(e => e.Ourtxt9).HasColumnName("OURTXT9");
            });

            modelBuilder.Entity<Tblpartner>(entity =>
            {
                entity.HasKey(e => e.Parid);

                entity.ToTable("TBLPartner");

                entity.Property(e => e.Parid).HasColumnName("PARID");

                entity.Property(e => e.Parimg1).HasColumnName("PARIMG1");
            });

            modelBuilder.Entity<Tblsay>(entity =>
            {
                entity.HasKey(e => e.Said)
                    .HasName("PK_TBLSay_1");

                entity.ToTable("TBLSay");

                entity.Property(e => e.Said).HasColumnName("SAID");

                entity.Property(e => e.Saimg1).HasColumnName("SAIMG1");

                entity.Property(e => e.Sajob1).HasColumnName("SAJob1");

                entity.Property(e => e.Saname1).HasColumnName("SAName1");

                entity.Property(e => e.Say1).HasColumnName("SAY1");
            });

            modelBuilder.Entity<Tblservice>(entity =>
            {
                entity.HasKey(e => e.Srvid);

                entity.ToTable("TBLService");

                entity.Property(e => e.Srvid).HasColumnName("SRVID");

                entity.Property(e => e.Sradres).HasColumnName("SRAdres");

                entity.Property(e => e.Sradres1).HasColumnName("SRAdres1");

                entity.Property(e => e.Sradres2).HasColumnName("SRAdres2");

                entity.Property(e => e.Sradres3).HasColumnName("SRAdres3");

                entity.Property(e => e.Sradres4).HasColumnName("SRAdres4");

                entity.Property(e => e.Sradres5).HasColumnName("SRAdres5");

                entity.Property(e => e.Sradres6).HasColumnName("SRAdres6");

                entity.Property(e => e.Sraskadress).HasColumnName("SRASKAdress");

                entity.Property(e => e.Srasktxt).HasColumnName("SRASKTXT");

                entity.Property(e => e.Srtxt).HasColumnName("SRTXT");

                entity.Property(e => e.Srtxt1).HasColumnName("SRTXT1");

                entity.Property(e => e.Srtxt2).HasColumnName("SRTXT2");

                entity.Property(e => e.Srtxt3).HasColumnName("SRTXT3");

                entity.Property(e => e.Srtxt4).HasColumnName("SRTXT4");

                entity.Property(e => e.Srtxt5).HasColumnName("SRTXT5");

                entity.Property(e => e.Srtxt6).HasColumnName("SRTXT6");
            });

            modelBuilder.Entity<TblshowWrk>(entity =>
            {
                entity.HasKey(e => e.Wrid);

                entity.ToTable("TBLShowWRK");

                entity.Property(e => e.Wrid).HasColumnName("WRID");

                entity.Property(e => e.Wradres).HasColumnName("WRAdres");

                entity.Property(e => e.Wrimg).HasColumnName("WRIMG");

                entity.Property(e => e.Wrlink).HasColumnName("WRLink");

                entity.Property(e => e.Wrtxt).HasColumnName("WRTXT");
            });

            modelBuilder.Entity<Tblsioweb>(entity =>
            {
                entity.HasKey(e => e.Sioid);

                entity.ToTable("TBLSIOWeb");

                entity.Property(e => e.Sioid).HasColumnName("SIOID");

                entity.Property(e => e.Siotxt).HasColumnName("SIOTXT");
            });

            modelBuilder.Entity<Tblslider>(entity =>
            {
                entity.HasKey(e => e.Idslider);

                entity.ToTable("TBLSlider");

                entity.Property(e => e.Idslider).HasColumnName("IDSlider");

                entity.Property(e => e.Sldadress1).HasColumnName("SLDAdress1");

                entity.Property(e => e.Sldadress2).HasColumnName("SLDAdress2");

                entity.Property(e => e.Sldadress3).HasColumnName("SLDAdress3");

                entity.Property(e => e.Sldadress4).HasColumnName("SLDAdress4");

                entity.Property(e => e.Sldadress5).HasColumnName("SLDAdress5");

                entity.Property(e => e.Sldmg1).HasColumnName("SLDMG1");

                entity.Property(e => e.Sldmg2).HasColumnName("SLDMG2");

                entity.Property(e => e.Sldmg3).HasColumnName("SLDMG3");

                entity.Property(e => e.Sldmg4).HasColumnName("SLDMG4");

                entity.Property(e => e.Sldmg5).HasColumnName("SLDMG5");

                entity.Property(e => e.Sldtxt1).HasColumnName("SLDTXT1");

                entity.Property(e => e.Sldtxt2).HasColumnName("SLDTXT2");

                entity.Property(e => e.Sldtxt3).HasColumnName("SLDTXT3");

                entity.Property(e => e.Sldtxt4).HasColumnName("SLDTXT4");

                entity.Property(e => e.Sldtxt5).HasColumnName("SLDTXT5");

                entity.Property(e => e.Undadress1).HasColumnName("UNDAdress1");

                entity.Property(e => e.Undadress2).HasColumnName("UNDAdress2");

                entity.Property(e => e.Undadress3).HasColumnName("UNDAdress3");

                entity.Property(e => e.Undtxt1).HasColumnName("UNDTXT1");

                entity.Property(e => e.Undtxt2).HasColumnName("UNDTXT2");

                entity.Property(e => e.Undtxt3).HasColumnName("UNDTXT3");
            });

            modelBuilder.Entity<TblusersMail>(entity =>
            {
                entity.HasKey(e => e.MailId);

                entity.ToTable("TBLUsersMail");

                entity.Property(e => e.MailId).HasColumnName("MAilID");

                entity.Property(e => e.MailName).HasMaxLength(200);
            });

            modelBuilder.Entity<Tblweb>(entity =>
            {
                entity.HasKey(e => e.Webid);

                entity.ToTable("TBLWEB");

                entity.Property(e => e.Webid).HasColumnName("WEBID");

                entity.Property(e => e.Webcard).HasColumnName("WEBCard");

                entity.Property(e => e.Webprice).HasColumnName("WEBPrice");

                entity.Property(e => e.Webtitel).HasColumnName("WEBTitel");

                entity.Property(e => e.WebtitelTxt).HasColumnName("WEBTitelTXT");

                entity.Property(e => e.Webtxt1).HasColumnName("WEBTXT1");

                entity.Property(e => e.Webtxt10).HasColumnName("WEBTXT10");

                entity.Property(e => e.Webtxt2).HasColumnName("WEBTXT2");

                entity.Property(e => e.Webtxt3).HasColumnName("WEBTXT3");

                entity.Property(e => e.Webtxt4).HasColumnName("WEBTXT4");

                entity.Property(e => e.Webtxt5).HasColumnName("WEBTXT5");

                entity.Property(e => e.Webtxt6).HasColumnName("WEBTXT6");

                entity.Property(e => e.Webtxt7).HasColumnName("WEBTXT7");

                entity.Property(e => e.Webtxt8).HasColumnName("WEBTXT8");

                entity.Property(e => e.Webtxt9).HasColumnName("WEBTXT9");
            });

            modelBuilder.Entity<TeacherView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TeacherView");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AcountName).HasMaxLength(250);

                entity.Property(e => e.Bilid).HasColumnName("BILID");

                entity.Property(e => e.BillDt)
                    .HasColumnType("date")
                    .HasColumnName("BillDT");

                entity.Property(e => e.BillInvalue).HasColumnName("BillINValue");

                entity.Property(e => e.BillOutvalue).HasColumnName("BillOUTValue");

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.Crid).HasColumnName("CRID");

                entity.Property(e => e.Cuname).HasColumnName("CUName");

                entity.Property(e => e.Endid).HasColumnName("ENDID");

                entity.Property(e => e.Endname)
                    .HasMaxLength(50)
                    .HasColumnName("ENDName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PNotice)
                    .HasMaxLength(50)
                    .HasColumnName("p_notice");

                entity.Property(e => e.SubBillId).HasColumnName("SubBillID");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<TfweedMasareefTbl>(entity =>
            {
                entity.ToTable("tfweed_masareef_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Custname)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("custname");

                entity.Property(e => e.MDate)
                    .HasColumnType("date")
                    .HasColumnName("m_date");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PayNotes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pay_notes");

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TfweedMasareefTbls)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tfweed_masareef_tbl_account");

                entity.HasOne(d => d.TIdNavigation)
                    .WithMany(p => p.TfweedMasareefTbls)
                    .HasForeignKey(d => d.TId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tfweed_masareef_tbl_tfweed_tbl");
            });

            modelBuilder.Entity<TfweedMoney>(entity =>
            {
                entity.ToTable("tfweed_money");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.MDate)
                    .HasColumnType("date")
                    .HasColumnName("m_date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .HasColumnName("notes");

                entity.Property(e => e.PayNotes)
                    .HasMaxLength(300)
                    .HasColumnName("pay_notes");

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TfweedMoneys)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tfweed_money_account");

                entity.HasOne(d => d.TIdNavigation)
                    .WithMany(p => p.TfweedMoneys)
                    .HasForeignKey(d => d.TId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tfweed_money_tfweed_tbl");
            });

            modelBuilder.Entity<TfweedTbl>(entity =>
            {
                entity.ToTable("tfweed_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.CustNo)
                    .HasMaxLength(50)
                    .HasColumnName("cust_no")
                    .HasDefaultValueSql("(N'..')");

                entity.Property(e => e.Masroof)
                    .HasColumnType("money")
                    .HasColumnName("masroof");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("p_name");

                entity.Property(e => e.PayedM)
                    .HasColumnType("money")
                    .HasColumnName("payed_m");

                entity.Property(e => e.Rebh)
                    .HasColumnType("money")
                    .HasColumnName("rebh");

                entity.Property(e => e.RemainM)
                    .HasColumnType("money")
                    .HasColumnName("remain_m");

                entity.Property(e => e.TDate)
                    .HasColumnType("date")
                    .HasColumnName("t_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TNo)
                    .HasColumnName("t_no")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Visadate)
                    .HasMaxLength(50)
                    .HasColumnName("visadate");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<TransMadyonaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Trans_Madyona_View");

                entity.Property(e => e.AqedDate)
                    .HasColumnType("date")
                    .HasColumnName("aqed_date");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("c_name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OfficeSource)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("office_source");

                entity.Property(e => e.Paymentmony)
                    .HasColumnType("money")
                    .HasColumnName("paymentmony");

                entity.Property(e => e.Personcode)
                    .HasMaxLength(50)
                    .HasColumnName("personcode");

                entity.Property(e => e.Personouside)
                    .HasMaxLength(50)
                    .HasColumnName("personouside");

                entity.Property(e => e.RecName)
                    .HasMaxLength(200)
                    .HasColumnName("rec_name");

                entity.Property(e => e.RemainBalance).HasColumnName("remain_balance");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TransmitId).HasColumnName("transmit_id");

                entity.Property(e => e.Visano)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<TransationTbl>(entity =>
            {
                entity.ToTable("transation_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.DateValid)
                    .HasColumnType("datetime")
                    .HasColumnName("date_valid");

                entity.Property(e => e.IsValidated).HasColumnName("is_validated");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasColumnName("notes");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.TranAmount)
                    .HasColumnType("money")
                    .HasColumnName("tran_amount");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tran_date");

                entity.Property(e => e.TranType).HasColumnName("tran_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserValid).HasColumnName("user_valid");
            });

            modelBuilder.Entity<TransferAccount>(entity =>
            {
                entity.ToTable("transfer_account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.FromAccount).HasColumnName("from_account");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.PNote)
                    .HasMaxLength(150)
                    .HasColumnName("p_note")
                    .HasDefaultValueSql("(N'...')");

                entity.Property(e => e.TDate)
                    .HasColumnType("date")
                    .HasColumnName("t_date");

                entity.Property(e => e.ToAccount).HasColumnName("to_account");

                entity.Property(e => e.WhoHand)
                    .HasMaxLength(150)
                    .HasColumnName("who_hand")
                    .HasDefaultValueSql("(N'...')");

                entity.HasOne(d => d.FromAccountNavigation)
                    .WithMany(p => p.TransferAccountFromAccountNavigations)
                    .HasForeignKey(d => d.FromAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_transfer_account_account");

                entity.HasOne(d => d.ToAccountNavigation)
                    .WithMany(p => p.TransferAccountToAccountNavigations)
                    .HasForeignKey(d => d.ToAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_transfer_account_account1");
            });

            modelBuilder.Entity<TransmittTbl>(entity =>
            {
                entity.ToTable("transmitt_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasColumnName("notes");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.TransDate)
                    .HasColumnType("date")
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("trans_name");
            });

            modelBuilder.Entity<TransmittalVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TRANSMITTAL_vw");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("id_num");

                entity.Property(e => e.Kafeelname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("kafeelname");

                entity.Property(e => e.Offid).HasColumnName("offid");

                entity.Property(e => e.OwnernameEn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ownername_en");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passportno");

                entity.Property(e => e.Recname)
                    .HasMaxLength(200)
                    .HasColumnName("recname");

                entity.Property(e => e.TransmitId).HasColumnName("transmit_id");

                entity.Property(e => e.Visano)
                    .HasMaxLength(50)
                    .HasColumnName("visano");
            });

            modelBuilder.Entity<TranstionVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("transtion_vw");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Da3n)
                    .HasColumnType("money")
                    .HasColumnName("da3n");

                entity.Property(e => e.DateValid)
                    .HasColumnType("datetime")
                    .HasColumnName("date_valid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsValidated).HasColumnName("is_validated");

                entity.Property(e => e.Madin)
                    .HasColumnType("money")
                    .HasColumnName("madin");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasColumnName("notes");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.TranDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tran_date");

                entity.Property(e => e.TranType).HasColumnName("tran_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserValid).HasColumnName("user_valid");
            });

            modelBuilder.Entity<TrialBalanceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TrialBalanceView");

                entity.Property(e => e.Accdlt).HasColumnName("ACCDLT");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Acctyp).HasColumnName("ACCTYP");

                entity.Property(e => e.AcountId).HasColumnName("AcountID");

                entity.Property(e => e.AcountName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EndInvl).HasColumnName("EndINVL");

                entity.Property(e => e.EndOutVl).HasColumnName("EndOutVL");

                entity.Property(e => e.FirstInvl).HasColumnName("FirstINVL");

                entity.Property(e => e.FirstOutVl).HasColumnName("FirstOutVL");

                entity.Property(e => e.Totinvl).HasColumnName("TOTINVL");

                entity.Property(e => e.Totoutvl).HasColumnName("TOTOUTVL");

                entity.Property(e => e.Tottvl).HasColumnName("TOTTVL");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.ToTable("user_permission");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsAdd).HasColumnName("is_add");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.IsUpdate).HasColumnName("is_update");

                entity.Property(e => e.PermId).HasColumnName("perm_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Perm)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.PermId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_permission_permission1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_permission_user_tbl1");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.ToTable("user_tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BranchId)
                    .HasColumnName("branch_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Officeid).HasColumnName("officeid");

                entity.Property(e => e.Passwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("passwd");

                entity.Property(e => e.UType).HasColumnName("u_type");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<WebShow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebShow");

                entity.Property(e => e.AccountVl).HasColumnName("AccountVL");

                entity.Property(e => e.CloseUser).HasColumnName("close_user");

                entity.Property(e => e.Closedate)
                    .HasColumnType("date")
                    .HasColumnName("closedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Musaned).HasColumnName("musaned");

                entity.Property(e => e.Officeidentity)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("officeidentity");

                entity.Property(e => e.SadadType).HasColumnName("sadad_type");

                entity.Property(e => e.Service).HasColumnName("service");

                entity.Property(e => e.States).HasColumnName("states");

                entity.Property(e => e.Tafweed).HasColumnName("tafweed");

                entity.Property(e => e.Tajeer).HasColumnName("tajeer");
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.ToTable("years");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.YearFrom)
                    .HasColumnType("date")
                    .HasColumnName("year_from");

                entity.Property(e => e.YearName).HasColumnName("year_name");

                entity.Property(e => e.YearTo)
                    .HasColumnType("date")
                    .HasColumnName("year_to");
            });

            modelBuilder.Entity<YearView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("year_view");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
