using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class BL_PageContent
    {
        public static string VarOutput { get; set; }
       

        public static void COP3488()
        {
            VarOutput = null;

            string[] names = new string[5] { "Course Number: " + "COP3488C", "Course Name: " + "Universal Windows Applications Programming I", "Description: This course provides students an introduction to the basic features of the Microsoft C# " +
                "programming language as it applies to Universal Windows Application mobile application development. Students will review the history, features, and advantages of the C# programming language, utilize the Visual Studio programming " +
                "environment, demonstrate a mastery of C# programming basics, and develop a basic Universal Windows Application.", "Course Credits: " + "4", "Prerequisites: " + "Enterprise Arch; Distributed App Arch" };
            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }

        }
        public static void CTS3302()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CTS3302", "Course Name: " + "Fundaments of Cloud Computing", "Description: This course will introduce students to various technologies and services utilized in cloud computing. " +
                "The course will focus on practical application of cloud deployment methodologies. Topics include the evolution of cloud computing technology, examination of cloud deployment and cloud service models, and designing a cloud computing " +
                "strategy to meet specific business needs.", "Course Credits: " + "4", "Prerequisites: " + "None" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CIS3917()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CIS3917", "Course Name: " + "Fundamentals of Distributed Database Management", "Description: This course is the study of distributed databases and the technical " +
                "architecture they reside on. It places focus on geographically separated databases where through database replication, end users experience database transparency. Topics include the differences between distributed "
                + "databases and stand-alone database management systems, scalability, replication, and overall high availability concepts as they relate to distributed databases. This course will prepare students to implement enterprise worthy, " +
                "geographically separated databases.", "Course Credits: " + "4", "Prerequisites: " + "None" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CIS3801()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CIS3801", "Course Name: " + "Fundamentals of Mobile Web Applications Development", "Description: This course presents the fundamentals of mobile web applications " +
                "development. It places a focus on implementing well-defined mobile application standards, while designing a mobile application as a business solution to a real business scenario. Topics include mobile application " +
                "standards, selecting appropriate content adaptation strategies, and following the system's development life cycle to plan, design, test, and deploy a mobile application. This course will prepare students to develop a " +
                "professional mobile application that meets today’s business standards.", "Course Credits: " + "4", "Prerequisites: " + "None" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }

        public static void CIS4655()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CIS4655", "Course Name: " + "Advanced Mobile Web Application Development", "Description: This course is the study of advanced mobile application development. " +
                "It places a detailed focus on building a mobile application user interface, planning and designing database models, and deploying mobile applications to emulators, as well as popular mobile application stores. " +
                "Topics include designing a professional graphical prototype of the user interface, designing navigation that meets usability requirements, constructing data models and databases, interfacing code to databases, and " +
                "testing then deploying an application to popular application stores. This course will prepare students to create more advanced mobile applications that interact with cloud-based databases.", "Course Credits: " + "4", "Prerequisites: " + "Fund Mobile Web App Devlpmnt" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CDA3315()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CDA3315", "Course Name: " + "Fundamentals of Enterprise Architecture", "Description: This course is the study of business "+
                "enterprise analysis, design, planning and implementation. It places focus on working with stakeholders, modeling business data flows and interfaces, determining the information" +
                " security risk for an organization, and re - engineering business processes.Topics include current software development methodologies, business process modeling, and enterprise "+
                "information security methodologies.This course will prepare students to work with stakeholders to ensure that information technology is in alignment with the goals of the business.", "Course Credits: " + "4", "Prerequisites: " + "NONE" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CDA3428()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CDA3428", "Course Name: " + "Fundamentals of Distributed Application Architecture", "Description: This course is the study of the design and use of distributed " +
                "software applications as part of a enterprise architecture in a typical business. It places focus on the software development process, business process analysis, and generating functional requirements for business " +
                "technology. Topics include software architecture, business process analysis, agile development, and scalability. This course will prepare students for producing a software development project plan, documenting hardware " +
                "and software requirements to support current and future transaction loads, and modeling end-to-end data flows for a given business process.", "Course Credits: " + "4", "Prerequisites: " + "NONE" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CTS4623()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CTS4623", "Course Name: " + "Advanced Cloud Computing Technologies", "Description: This course will provide students with an in-depth understanding of computing technologies " +
                "and services for enterprise level application deployment projects. The course will focus on practical aspects of cloud based application architecture and deployment methodologies, using the Microsoft Azure cloud platform. " +
                "Topics include application scalability principles, application performance and benchmarking tools, authentication and authorization security issues, cloud deployment platform selection criteria, asset cataloging and management, " +
                "and other advanced cloud deployment topics.", "Course Credits: " + "4", "Prerequisites: " + "Fund Cloud Computing" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CTS3265()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CTS3265", "Course Name: " + "Introduction to Business Intelligence", "Description: This course is the study of the skills and techniques for analyzing business " +
                "performance data to provide support for business planning. It places focus on using query development, reporting, and analytical tools to help guide business decision-making. Topics include statistical analysis, " +
                "basic database design, and business process modeling. This course will prepare students to utilize information to support decision-making.", "Course Credits: " + "4", "Prerequisites: " + "NONE" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void COP4474()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "COP4474", "Course Name: " + "Universal Windows Applications Programming II", "Description: This course presents advanced application design and Microsoft C# " +
                "programming techniques related to Universal Windows Application development. Students will analyze user interface design and the Windows features that support it, demonstrate a mastery of Microsoft user interface tools, " +
                "construct a C# database application, and develop a basic C# mobile application that accesses Microsoft Azure.", "Course Credits: " + "4", "Prerequisites: " + "Univ Windows App Prog I" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void COP4777()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "COP4777", "Course Name: " + "Universal Windows Applications Cloud Integration", "Description: This course focuses on the development of Universal Windows mobile applications " +
                "that access cloud computing resources. Students will explore the software development kits (SDKs) available from commercial cloud vendors, demonstrate a mastery of the Amazon Web Services Mobile SDK, demonstrate a mastery of the " +
                "Microsoft Windows Azure Mobile Services SDK, and incorporate AWS or Azure functionality into a working Universal Windows mobile application.", "Course Credits: " + "4", "Prerequisites: " + "Univ Windows App Prog II" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CIS4836()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CIS4836", "Course Name: " + "Web Analytics", "Description: This course is the study of contemporary business analytics tools. It places a focus on determining the most " +
                "appropriate product or technology for building data visualizations and dashboards. Topics include identifying analytical tools, highlighting various input and output data formats, identifying different types of data visualizations, " +
                "and constructing business-oriented dashboards. This course will prepare students to be able to create data visualizations and dashboards based on provided business requirements.", "Course Credits: " + "4", "Prerequisites: " + "NONE" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CIS4793()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CIS4793", "Course Name: " + "Database Implementation Strategies for Programmers", "Description: The focus of this course " +
                "is to provide programmers the information necessary to interface mobile software applications with cloud-based distributed databases. Topics include a review of database " +
                "fundamentals, database connectivity, query optimization, and the use of application program interfaces (APIs) as they relate to specific vendor databases. This course will " +
                "prepare students to extract data from a distributed database and then present the data within a mobile software application.", "Course Credits: " + "4", "Prerequisites: " + "NONE" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CTS4557()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CTS4557", "Course Name: " + "Emerging Trends in Technology", "Description: This course is the study of emerging technologies. It places focus on technology impact on business and society in general. " +
                "Topics include the relationship between emerging technologies and business opportunities, analysis of costs and savings of implementing particular technologies, legal and ethical issues affecting technology, " +
                "challenges of adapting new technologies, and impacts of technology." , "Course Credits: " + "3", "Prerequisites: " + "NONE" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void MAN3504()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "MAN3504", "Course Name: " + "Operations Management", "Description: In this course students examine the operations function of managing people, "+
                "information, technology, materials, and facilities to produce goods and services. Specific areas covered will include: designing and managing operations; purchasing raw materials; controlling and "+
                "maintaining inventories; and producing good or services that meet customers' expectations. Quantitative modeling will be used for solving business problems.", "Course Credits: " + "4", "Prerequisites: " + "NONE" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void GEB3422()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "GEB3422", "Course Name: " + "Business Project Management", "Description: This course is a study of the characteristics and functions of project management, " +
                "team building, and facilitation. It places focus on project planning, scope, scheduling, and controlling of projects through completion. It reinforces and builds upon skills and knowledge students have learned " +
                "in all of the various disciplines within the Business curriculum. It is recommended that students take this course their final quarter.", "Course Credits: " + "4", "Prerequisites: " + "NONE" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void CIS4910()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "CIS4910", "Course Name: " + "Computer Science Capstone", "Description: This course is the culmination of the diverse skill set previously gained throughout the program. "+
                "It places focus on project management skills, communication, and critical thinking as they relate to constructing an end-to-end technical solution. This course will incorporate a different project focus each term where students " +
                "will collaborate in the development of a mobile/cloud application system.", "Course Credits: " + "3", "Prerequisites: " + "Technology Bachelor's student in final term" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void COP3362()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "COP3362", "Course Name: " + "Apple iOS Programming I", "Description: This course provides students an introduction to the basic features of the Apple Swift programming language as " +
                "it applies to iOS mobile application development. Students will review the history, features, and advantages of the Swift programming language, utilize the Apple Xcode programming environment, demonstrate a mastery of Swift programming " +
                "basics, and develop a basic Apple Swift mobile application.", "Course Credits: " + "4", "Prerequisites: " + "Enterprise Architecture, Distributed Application Architecture" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void COP4309()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "COP4309", "Course Name: " + "Apple iOS Programming II", "Description: This course presents advanced application design and Apple Swift programming techniques related to iOS mobile application development. " +
                "Students will analyze user interface design and the iOS features that support it, demonstrate a mastery of Apple user interface tools, construct a Swift database application, and develop a basic Apple Swift mobile application that accesses " +
                "iCloud.", "Course Credits: " + "4", "Prerequisites: " + "Apple iOS Programming I" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static void COP4683()
        {
            VarOutput = null;
            string[] names = new string[5] { "Course Number: " + "COP4683", "Course Name: " + "Apple iOS Cloud Integration", "Description: This course focuses on the development of iOS mobile applications that access cloud computing resources. Students will explore the software " +
                "development kits (SDKs) available from commercial cloud vendors, demonstrate a mastery of the Amazon Web Services Mobile SDK, demonstrate a mastery of the Microsoft Windows Azure Mobile Services iOS SDK, and incorporate AWS or Azure functionality into a working " +
                "iOS mobile application.", "Course Credits: " + "4", "Prerequisites: " + "Apple iOS Programming II" };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "\r\n" + "\r\n";
            }
        }
        public static string CreatedBy { get; set; }
    }
}
