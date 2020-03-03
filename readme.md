# Entity Framework shadow properties

This repository supports the following [Microsoft TechNet article](https://social.technet.microsoft.com/wiki/contents/articles/53662.entity-framework-core-shadow-properties-c.aspx).


```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

    modelBuilder.Entity<Contact>().Property<DateTime?>("LastUpdated");
    modelBuilder.Entity<Contact>().Property<string>("LastUser");

    modelBuilder.Entity<Contact1>().Property<DateTime?>("LastUpdated");
    modelBuilder.Entity<Contact1>().Property<string>("LastUser");
    modelBuilder.Entity<Contact1>().Property<DateTime?>("CreatedAt");
    modelBuilder.Entity<Contact1>().Property<string>("CreatedBy");
    modelBuilder.Entity<Contact1>().Property<bool>("isDeleted");


    modelBuilder.Entity<Contact>(entity =>
    {
        entity.HasKey(e => e.ContactId);
    });
    modelBuilder.Entity<Contact1>(entity =>
    {
        entity.HasKey(e => e.ContactId);
    });

    /*
     * Setup filter on Contact1 model to show only active records.
     * Since IsDeleted is not in the model the string name is used.
     */
    modelBuilder.Entity<Contact1>()
        .HasQueryFilter(m => 
            EF.Property<bool>(m, "isDeleted") == false);

    OnModelCreatingPartial(modelBuilder);

}
```