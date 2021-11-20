using Microsoft.EntityFrameworkCore;

namespace Ipms.Core.Data.Contexts
{
    public partial class IpmsDbContext : DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public IpmsDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        public virtual DbSet<BankName> BankNames { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CompanyInformation> CompanyInformations { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrVoucher> CrVouchers { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfos { get; set; }
        public virtual DbSet<CustomerIntialDue> CustomerIntialDues { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<CutomerType> CutomerTypes { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<DrVoucher> DrVouchers { get; set; }
        public virtual DbSet<DuePaymentDeleteHistory> DuePaymentDeleteHistories { get; set; }
        public virtual DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }
        public virtual DbSet<EmployeeInformation> EmployeeInformations { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<FactoryInfo> FactoryInfos { get; set; }
        public virtual DbSet<FactoryUnitInfo> FactoryUnitInfos { get; set; }
        public virtual DbSet<LabourCostInfo> LabourCostInfos { get; set; }
        public virtual DbSet<LoginHistory> LoginHistories { get; set; }
        public virtual DbSet<PaymentInfo> PaymentInfos { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<ProductList> ProductLists { get; set; }
        public virtual DbSet<ProductPurchase> ProductPurchases { get; set; }
        public virtual DbSet<ProductPurchaseRecordList> ProductPurchaseRecordLists { get; set; }
        public virtual DbSet<ProductSell> ProductSells { get; set; }
        public virtual DbSet<ProductSellDelete> ProductSellDeletes { get; set; }
        public virtual DbSet<ProductSellRecord> ProductSellRecords { get; set; }
        public virtual DbSet<ProductSellRecordDelete> ProductSellRecordDeletes { get; set; }
        public virtual DbSet<ProductStock> ProductStocks { get; set; }
        public virtual DbSet<SellReturn> SellReturns { get; set; }
        public virtual DbSet<SellReturnRecord> SellReturnRecords { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<SubContactItem> SubContactItems { get; set; }
        public virtual DbSet<SubContactItemsRecord> SubContactItemsRecords { get; set; }
        public virtual DbSet<SubContactor> SubContactors { get; set; }
        public virtual DbSet<SubContactorPaymentInfo> SubContactorPaymentInfos { get; set; }
        public virtual DbSet<TargetPayment> TargetPayments { get; set; }
        public virtual DbSet<Upazila> Upazilas { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRoll> UserRolls { get; set; }
        public virtual DbSet<VendorInformation> VendorInformations { get; set; }
        public virtual DbSet<VendorPaymentRecord> VendorPaymentRecords { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BankName");

                entity.Property(e => e.AccountHolderName).HasMaxLength(100);

                entity.Property(e => e.AccountNo).HasMaxLength(25);

                entity.Property(e => e.AccountType).HasMaxLength(40);

                entity.Property(e => e.BankContactNo).HasMaxLength(15);

                entity.Property(e => e.BankName1)
                    .HasMaxLength(75)
                    .HasColumnName("BankName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.BrandIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Brands)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Brand__CategoryI__534D60F1");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CompanyInformation>(entity =>
            {
                entity.ToTable("CompanyInformation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComNameBengla)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ComNameEnglish)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyLogo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerPhoto1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerPhoto2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TradeLicense)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.WebAddress)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrVoucher");

                entity.Property(e => e.CrVoucher1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CrVoucher");

                entity.Property(e => e.ExpenseDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerInfo");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nid)
                    .HasMaxLength(255)
                    .HasColumnName("NID");

                entity.Property(e => e.Photos).HasMaxLength(255);

                entity.Property(e => e.TradeName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerIntialDue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerIntialDue");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CutomerType>(entity =>
            {
                entity.ToTable("CutomerType");

                entity.Property(e => e.CutomerTypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("Designation");

                entity.Property(e => e.DesignationDesciption)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.DesignationName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Districts__Divis__35BCFE0A");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.Property(e => e.DivisionName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Divisions__Count__31EC6D26");
            });

            modelBuilder.Entity<DrVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DrVoucher");

                entity.Property(e => e.DrVoucherid).ValueGeneratedOnAdd();

                entity.Property(e => e.IncomeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DuePaymentDeleteHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DuePaymentDeleteHistory");

                entity.Property(e => e.DeleteDate).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.VoucharNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeAttendance>(entity =>
            {
                entity.ToTable("EmployeeAttendance");

                entity.Property(e => e.DeviceEmpId).HasMaxLength(25);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryTime).HasMaxLength(25);

                entity.Property(e => e.OutTime).HasMaxLength(25);
            });

            modelBuilder.Entity<EmployeeInformation>(entity =>
            {
                entity.HasKey(e => e.EmployeId)
                    .HasName("PK__Employee__6251442F0B54B7C0");

                entity.ToTable("EmployeeInformation");

                entity.Property(e => e.ContactNumber).HasMaxLength(255);

                entity.Property(e => e.EmpMobileNo).HasMaxLength(15);

                entity.Property(e => e.EmployeeName).HasMaxLength(255);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.Nid)
                    .HasMaxLength(255)
                    .HasColumnName("NID");

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.Property(e => e.PresentSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryGradeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartingSalary).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.EmployeeInformations)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeI__Desig__45F365D3");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.EmployeeInformations)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeI__Emplo__46E78A0C");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.EmployeeInformations)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeI__Facto__440B1D61");

                entity.HasOne(d => d.FactoryUnit)
                    .WithMany(p => p.EmployeeInformations)
                    .HasForeignKey(d => d.FactoryUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeI__Facto__44FF419A");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EmployeeType");

                entity.Property(e => e.EmployeeTypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FactoryInfo>(entity =>
            {
                entity.HasKey(e => e.FactoryId)
                    .HasName("PK__FactoryI__732C8F7DFFE32651");

                entity.ToTable("FactoryInfo");

                entity.Property(e => e.FactoryAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FactoryEmail).HasMaxLength(255);

                entity.Property(e => e.FactoryIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.FactoryMobileNo).HasMaxLength(255);

                entity.Property(e => e.FactoryName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FactoryPhoto1).HasMaxLength(255);
            });

            modelBuilder.Entity<FactoryUnitInfo>(entity =>
            {
                entity.HasKey(e => e.FactoryUnitId)
                    .HasName("PK__Factory___9E3E509B6AE75F09");

                entity.ToTable("Factory_UnitInfo");

                entity.Property(e => e.FactoryUnitIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.FactoryUnitName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FactoryUnitInfos)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factory_U__Facto__2D27B809");
            });

            modelBuilder.Entity<LabourCostInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LabourCostInfo");

                entity.Property(e => e.CostType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabourCostId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<LoginHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoginHistory");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LoginDate).HasColumnType("date");
            });

            modelBuilder.Entity<PaymentInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentInfo");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PaymentInfoId).ValueGeneratedOnAdd();

                entity.Property(e => e.VoucharNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentType");

                entity.Property(e => e.PaymentTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductList");

                entity.Property(e => e.IsProductActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductListId).ValueGeneratedOnAdd();

                entity.Property(e => e.TempPrate)
                    .HasColumnName("tempPRate")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProductPurchase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductPurchase");

                entity.Property(e => e.DoNo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<ProductPurchaseRecordList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductPurchaseRecordList");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<ProductSell>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductSell");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductSellId).ValueGeneratedOnAdd();

                entity.Property(e => e.SellingDate).HasColumnType("date");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductSellDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductSellDelete");

                entity.Property(e => e.ProductSellDeleteId).ValueGeneratedOnAdd();

                entity.Property(e => e.SellingDate).HasColumnType("date");
            });

            modelBuilder.Entity<ProductSellRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductSellRecord");

                entity.Property(e => e.ProductSellRecordId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ProductSellRecordDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductSellRecordDelete");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<ProductStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductStock");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<SellReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SellReturn");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.SellReturn1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SellReturn");
            });

            modelBuilder.Entity<SellReturnRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SellReturnRecord");

                entity.Property(e => e.SellReturnRecordId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size");

                entity.Property(e => e.SizeIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SizeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Sizes)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Size__BrandId__571DF1D5");
            });

            modelBuilder.Entity<SubContactItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('Tk')");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.SubContactItemsId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SubContactItemsRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubContactItemsRecord");

                entity.Property(e => e.SubContactItemsRecordId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SubContactor>(entity =>
            {
                entity.HasKey(e => e.ContactorId)
                    .HasName("PK__SubConta__DDF4ADFEF86AE0B5");

                entity.Property(e => e.ContactNumber).HasMaxLength(255);

                entity.Property(e => e.ContactorName).HasMaxLength(255);

                entity.Property(e => e.ContactorNid)
                    .HasMaxLength(255)
                    .HasColumnName("ContactorNID");

                entity.Property(e => e.ContactorPhoto).HasMaxLength(255);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubContactorPaymentInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubContactorPaymentInfo");

                entity.Property(e => e.ContactorPaymentInfoId).ValueGeneratedOnAdd();

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('Tk')");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.VoucharNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TargetPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TargetPayment");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.TargetPaymentId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Upazila>(entity =>
            {
                entity.ToTable("Upazila");

                entity.Property(e => e.UpazilaName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Upazilas)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Upazila__Distric__38996AB5");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Employe)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmployeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__EmployeId__4BAC3F29");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__RoleId__4CA06362");
            });

            modelBuilder.Entity<UserRoll>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__UserRoll__8AFACE1ABD068098");

                entity.ToTable("UserRoll");

                entity.Property(e => e.RoleDesciption)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorInformation>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK__VendorIn__FC8618F3A26AA9D2");

                entity.ToTable("VendorInformation");

                entity.Property(e => e.ContactNumber).HasMaxLength(255);

                entity.Property(e => e.FatherName).HasMaxLength(255);

                entity.Property(e => e.OpeningDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('2017-01-01')");

                entity.Property(e => e.VendorName).HasMaxLength(255);

                entity.Property(e => e.VendorPhoto).HasMaxLength(255);
            });

            modelBuilder.Entity<VendorPaymentRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VendorPaymentRecord");

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.VendorPaymentRecord1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VendorPaymentRecord");
            });

            modelBuilder.Entity<Weight>(entity =>
            {
                entity.ToTable("Weight");

                entity.Property(e => e.WeightIsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.WeightName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Weights)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Weight__SizeId__45BE5BA9");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
