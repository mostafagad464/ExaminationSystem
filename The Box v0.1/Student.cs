//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace The_Box_v0._1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Student1 = new HashSet<Student>();
            this.Student_Courses = new HashSet<Student_Courses>();
            this.Student_Exam = new HashSet<Student_Exam>();
        }
    
        public int Std_ID { get; set; }
        public string Std_Email { get; set; }
        public string Std_UserName { get; set; }
        public string Std_Password { get; set; }
        public string Std_Name { get; set; }
        public Nullable<int> Std_Age { get; set; }
        public int Track_Id { get; set; }
        public Nullable<int> Leader_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student1 { get; set; }
        public virtual Student Student2 { get; set; }
        public virtual Track Track { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Courses> Student_Courses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Exam> Student_Exam { get; set; }
    }
}