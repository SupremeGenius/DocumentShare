using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace nsdoc
{
    #region Interface classes

    public interface intusr
    {
        Int32 usrcod
        { get; set; }
        string usrnam
        { get; set; }
        string usreml
        { get; set; }
        string usrpwd
        { get; set; }
        DateTime usrregdat
        { get; set; }
        string usrsecqst
        { get; set; }
        string usrsecans
        { get; set; }
        char usrsts
        { get; set; }
    }
    public interface intprf
    {
        Int32 prfcod
        { get; set; }
        Int32 prfusrcod
        { get; set; }
        string prfpic
        { get; set; }
        char prfgnd
        { get; set; }
        string prfdob
        { get; set; }
        string prfdsc
        { get; set; }
        string prfloc
        { get; set; }
    }
    public interface intlst
    {
        Int32 lstcod
        { get; set; }
        string lstnam
        { get; set; }
        Int32 lstusrcod
        { get; set; }
        DateTime lstcrtdat
        { get; set; }
    }
    public interface intdoc
    {
        Int32 doccod
        { get; set; }
        string doctit
        { get; set; }
        string docdsc
        { get; set; }
        string docfil
        { get; set; }
        Int32 doclstcod
        { get; set; }
        DateTime docupldat
        { get; set; }
        char docforsalsts
        { get; set; }
        float docprc
        { get; set; }
    }
    public interface intgrp
    {
        Int32 grpcod
        { get; set; }
        string grpnam
        { get; set; }
        string grpdsc
        { get; set; }
        DateTime grpcrtdat
        { get; set; }
        Int32 grpownusrcod
        { get; set; }
    }
    public interface intgrpmem
    {
        Int32 grpmemcod
        { get; set; }
        Int32 grpmemgrpcod
        { get; set; }
        Int32 grpmemusrcod
        { get; set; }
        DateTime grpmemjondat
        { get; set; }
    }
    public interface intpst
    {
        Int32 pstcod
        { get; set; }
        Int32 pstgrpcod
        { get; set; }
        Int32 pstusrcod
        { get; set; }
        DateTime pstdat
        { get; set; }
        string pstdsc
        { get; set; }
    }
    public interface intshr
    {
        Int32 shrcod
        { get; set; }
        Int32 shrdoc
        { get; set; }
        char shrtyp
        { get; set; }
        Int32 shrusrcod
        { get; set; }
        Int32 shrgrpcod
        { get; set; }
        DateTime shrdat
        { get; set; }
        char shrrgt
        { get; set; }
    }
    public interface intpur
    {
        Int32 purcod
        { get; set; }
        DateTime purdat
        { get; set; }
        Int32 purusrcod
        { get; set; }
        Int32 purdoccod
        { get; set; }
    }

#endregion

    # region Property Classes

    public class clsusrprp : intusr
    {
        private Int32 prvusrcod;
        private string prvusrnam, prvusreml, prvusrpwd, prvusrsecqst, prvusrsecans;
        private DateTime prvusrregdat;
        private char prvusrsts;
        public int usrcod
        {
            get
            {
                return prvusrcod;
            }
            set
            {
                prvusrcod = value;
            }
        }

        public string usrnam
        {
            get
            {
                return prvusrnam;
            }
            set
            {
                prvusrnam = value;
            }
        }

        public string usreml
        {
            get
            {
                return prvusreml;
            }
            set
            {
                prvusreml = value;
            }
        }

        public string usrpwd
        {
            get
            {
                return prvusrpwd;
            }
            set
            {
                prvusrpwd = value;
            }
        }

        public DateTime usrregdat
        {
            get
            {
                return prvusrregdat;
            }
            set
            {
                prvusrregdat = value;
            }
        }

        public string usrsecqst
        {
            get
            {
                return prvusrsecqst;
            }
            set
            {
                prvusrsecqst = value;
            }
        }

        public string usrsecans
        {
            get
            {
                return prvusrsecans;
            }
            set
            {
                prvusrsecans = value;
            }
        }

        public char usrsts
        {
            get
            {
                return prvusrsts;
            }
            set
            {
                prvusrsts = value;
            }
        }
    }
    public class clsprfprp : intprf
    {
        private Int32 prvprfcod, prvprfusrcod;
        private string prvprfpic, prvprfdob, prvprfdsc, prvprfloc;
        private char prvprfgnd;
        public int prfcod
        {
            get
            {
                return prvprfcod;
            }
            set
            {
                prvprfcod = value;
            }
        }

        public int prfusrcod
        {
            get
            {
                return prvprfusrcod;
            }
            set
            {
                prvprfusrcod = value;
            }
        }

        public string prfpic
        {
            get
            {
                return prvprfpic;
            }
            set
            {
                prvprfpic = value;
            }
        }

        public char prfgnd
        {
            get
            {
                return prvprfgnd;
            }
            set
            {
                prvprfgnd = value;
            }
        }

        public string prfdob
        {
            get
            {
                return prvprfdob;
            }
            set
            {
                prvprfdob = value;
            }
        }

        public string prfdsc
        {
            get
            {
                return prvprfdsc;
            }
            set
            {
                prvprfdsc = value;
            }
        }

        public string prfloc
        {
            get
            {
                return prvprfloc;
            }
            set
            {
                prvprfloc = value;
            }
        }
    }
    public class clslstprp : intlst
    {
        private Int32 prvlstcod, prvlstusrcod;
        private string prvlstnam;
        private DateTime prvlstcrtdat;
        public int lstcod
        {
            get
            {
                return prvlstcod;
            }
            set
            {
                prvlstcod = value;
            }
        }

        public string lstnam
        {
            get
            {
                return prvlstnam;
            }
            set
            {
                prvlstnam = value;
            }
        }

        public int lstusrcod
        {
            get
            {
                return prvlstusrcod;
            }
            set
            {
                prvlstusrcod = value;
            }
        }

        public DateTime lstcrtdat
        {
            get
            {
                return prvlstcrtdat;
            }
            set
            {
                prvlstcrtdat = value;
            }
        }
    }
    public class clsdocprp : intdoc
    {
        private Int32 prvdoccod, prvdoclstcod;
        private string prvdoctit, prvdocdsc, prvdocfil;
        private DateTime prvdocupldat;
        private float prvdocprc;
        private char prvdocforsalsts;


        public int doccod
        {
            get
            {
                return prvdoccod;
            }
            set
            {
                prvdoccod = value;
            }
        }

        public string doctit
        {
            get
            {
                return prvdoctit;
            }
            set
            {
                prvdoctit = value;
            }
        }

        public string docdsc
        {
            get
            {
                return prvdocdsc;
            }
            set
            {
                prvdocdsc = value;
            }
        }

        public string docfil
        {
            get
            {
                return prvdocfil;
            }
            set
            {
                prvdocfil = value;
            }
        }

        public int doclstcod
        {
            get
            {
                return prvdoclstcod;
            }
            set
            {
                prvdoclstcod = value;
            }
        }

        public DateTime docupldat
        {
            get
            {
                return prvdocupldat;
            }
            set
            {
                prvdocupldat = value;
            }
        }

        public char docforsalsts
        {
            get
            {
                return prvdocforsalsts;
            }
            set
            {
                prvdocforsalsts = value;
            }
        }

        public float docprc
        {
            get
            {
                return prvdocprc;
            }
            set
            {
                prvdocprc = value;
            }
        }
    }
    public class clsgrpprp : intgrp
    {
        private Int32 prvgrpcod, prvgrpownusrcod;
        private string prvgrpnam, prvgrpdsc;
        private DateTime prvgrpcrtdat;
        public int grpcod
        {
            get
            {
                return prvgrpcod;
            }
            set
            {
                prvgrpcod = value;
            }
        }

        public string grpnam
        {
            get
            {
                return prvgrpnam;
            }
            set
            {
                prvgrpnam = value;
            }
        }

        public string grpdsc
        {
            get
            {
                return prvgrpdsc;
            }
            set
            {
                prvgrpdsc = value;
            }
        }

        public DateTime grpcrtdat
        {
            get
            {
                return prvgrpcrtdat;
            }
            set
            {
                prvgrpcrtdat = value;
            }
        }

        public int grpownusrcod
        {
            get
            {
                return prvgrpownusrcod;
            }
            set
            {
                prvgrpownusrcod = value;
            }
        }
    }
    public class clsgrpmemprp : intgrpmem
    {
        private Int32 prvgrpmemcod, prvgrpmemgrpcod, prvgrpmemusrcod;
        private DateTime prvgrpmemjondat;
        public int grpmemcod
        {
            get
            {
                return prvgrpmemcod;
            }
            set
            {
                prvgrpmemcod = value;
            }
        }

        public int grpmemgrpcod
        {
            get
            {
                return prvgrpmemgrpcod;
            }
            set
            {
                prvgrpmemgrpcod = value;
            }
        }

        public int grpmemusrcod
        {
            get
            {
                return prvgrpmemusrcod;
            }
            set
            {
                prvgrpmemusrcod = value;
            }
        }

        public DateTime grpmemjondat
        {
            get
            {
                return prvgrpmemjondat;
            }
            set
            {
                prvgrpmemjondat = value;
            }
        }
    }
    public class clspstprp : intpst
    {
        private Int32 prvpstcod, prvpstgrpcod, prvpstusrcod;
        private DateTime prvpstdat;
        private string prvpstdsc;
        public int pstcod
        {
            get
            {
                return prvpstcod;
            }
            set
            {
                prvpstcod = value;
            }
        }

        public int pstgrpcod
        {
            get
            {
                return prvpstgrpcod;
            }
            set
            {
                prvpstgrpcod = value;
            }
        }

        public int pstusrcod
        {
            get
            {
                return prvpstusrcod;
            }
            set
            {
                prvpstusrcod = value;
            }
        }

        public DateTime pstdat
        {
            get
            {
                return prvpstdat;
            }
            set
            {
                prvpstdat = value;
            }
        }

        public string pstdsc
        {
            get
            {
                return prvpstdsc;
            }
            set
            {
                prvpstdsc = value;
            }
        }
    }
    public class clsshrprp : intshr
    {
        private Int32 prvshrcod, prvshrdoc, prvshrusrcod, prvshrgrpcod;
        private char prvshrtyp, prvshrrgt;
        private DateTime prvshrdat;
        
        public int shrcod
        {
            get
            {
                return prvshrcod;
            }
            set
            {
                prvshrcod = value;
            }
        }

        public int shrdoc
        {
            get
            {
                return prvshrdoc;
            }
            set
            {
                prvshrdoc = value;
            }
        }

        public char shrtyp
        {
            get
            {
                return prvshrtyp;
            }
            set
            {
                prvshrtyp = value;
            }
        }

        public int shrusrcod
        {
            get
            {
                return prvshrusrcod;
            }
            set
            {
                prvshrusrcod = value;
            }
        }

        public int shrgrpcod
        {
            get
            {
                return prvshrgrpcod;
            }
            set
            {
                prvshrgrpcod = value;
            }
        }

        public DateTime shrdat
        {
            get
            {
                return prvshrdat;
            }
            set
            {
                prvshrdat = value;
            }
        }

        public char shrrgt
        {
            get
            {
                return prvshrrgt;
            }
            set
            {
                prvshrrgt = value;
            }
        }
    }
    public class clspurprp : intpur
    {
        private Int32 prvpurcod, prvpurusrcod, prvpurdoccod;
        private DateTime prvpurdat;
        public int purcod
        {
            get
            {
                return prvpurcod;
            }
            set
            {
                prvpurcod = value;
            }
        }

        public DateTime purdat
        {
            get
            {
                return prvpurdat;
            }
            set
            {
                prvpurdat = value;
            }
        }

        public int purusrcod
        {
            get
            {
                return prvpurusrcod;
            }
            set
            {
                prvpurusrcod = value;
            }
        }

        public int purdoccod
        {
            get
            {
                return prvpurdoccod;
            }
            set
            {
                prvpurdoccod = value;
            }
        }
    }

#endregion

    #region Connection class

    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        }
    }

    #endregion

    #region Main Classes

    public class clsusr : clscon
    {
        public Int32 srcusrs(String eml,Int32 doccod)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("srcusrs", con);
            cmd.CommandType = CommandType.StoredProcedure;
   cmd.Parameters.Add("@eml", SqlDbType.VarChar, 100).Value = eml;
   cmd.Parameters.Add("@doccod", SqlDbType.Int).Value = doccod;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction =
                                     ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }

   public DataSet srcusr(String eml,Int32 grpcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("srcusr", con);
          adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.SelectCommand.Parameters.Add("@eml", SqlDbType.VarChar, 50)
                  .Value = eml;
      adp.SelectCommand.Parameters.Add("@grpcod", SqlDbType.Int).Value
                     = grpcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public Int32 logincheck(String eml,String pwd)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar, 100).Value = eml;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 100).Value = pwd;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction = ParameterDirection
                                    .ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }

        public Int32 vrfusr(String eml)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("vrfusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar, 100).Value = eml;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction =
                                    ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }



        public void Save_Rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@usrnam", SqlDbType.VarChar, 100).Value = p.usrnam;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 100).Value = p.usreml;
            cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 100).Value = p.usrpwd;
            cmd.Parameters.Add("@usrregdat", SqlDbType.DateTime).Value = p.usrregdat;
            cmd.Parameters.Add("@usrsecqst", SqlDbType.VarChar, 100).Value = p.usrsecqst;
            cmd.Parameters.Add("@usrsecans", SqlDbType.VarChar, 100).Value = p.usrsecans;
            cmd.Parameters.Add("@usrsts", SqlDbType.Char, 1).Value = p.usrsts;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();

        }
        public void update_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = p.usrcod;
            cmd.Parameters.Add("@usrnam", SqlDbType.VarChar, 100).Value = p.usrnam;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 100).Value = p.usreml;
            cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 100).Value = p.usrpwd;
            cmd.Parameters.Add("@usrregdat", SqlDbType.DateTime).Value = p.usrregdat;
            cmd.Parameters.Add("@usrsecqst", SqlDbType.VarChar, 100).Value = p.usrsecqst;
            cmd.Parameters.Add("@usrsecans", SqlDbType.VarChar, 100).Value = p.usrsecans;
            cmd.Parameters.Add("@usrsts", SqlDbType.Char, 1).Value = p.usrsts;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void delete_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = p.usrcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();


        }
        public List<clsusrprp> disp_rec()
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("disusr", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsusrprp> obj = new List<clsusrprp>();
                while (dr.Read())
                {
                    clsusrprp x = new clsusrprp();
                    x.usrcod = Convert.ToInt32(dr[0]);
                    x.usrnam = dr[1].ToString();
                    x.usreml = dr[2].ToString();
                    x.usrpwd = dr[3].ToString();
                    x.usrregdat = Convert.ToDateTime(dr[4]);
                    x.usrsecqst = dr[5].ToString();
                    x.usrsecans = dr[6].ToString();
                    x.usrsts = Convert.ToChar(dr[7]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
        public List<clsusrprp> Find_Rec(String eml)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar,50).Value =eml;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsusrprp> obj = new List<clsusrprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsusrprp x = new clsusrprp();
                x.usrcod = Convert.ToInt32(dr[0]);
                x.usrnam = dr[1].ToString();
                x.usreml = dr[2].ToString();
                x.usrpwd = dr[3].ToString();
                x.usrregdat = Convert.ToDateTime(dr[4]);
                x.usrsecqst = dr[5].ToString();
                x.usrsecans = dr[6].ToString();
                x.usrsts = Convert.ToChar(dr[7]);
                obj.Add(x);

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }

        public List<clsusrprp> Find_info(Int32 usrcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndusrinfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
  cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value =usrcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsusrprp> obj = new List<clsusrprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsusrprp x = new clsusrprp();
                x.usrcod = Convert.ToInt32(dr[0]);
                x.usrnam = dr[1].ToString();
                x.usreml = dr[2].ToString();
                x.usrpwd = dr[3].ToString();
                x.usrregdat = Convert.ToDateTime(dr[4]);
                x.usrsecqst = dr[5].ToString();
                x.usrsecans = dr[6].ToString();
                x.usrsts = Convert.ToChar(dr[7]);
                obj.Add(x);

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsprf : clscon
    {
        public void Save_Rec(clsprfprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfusrcod", SqlDbType.Int).Value = p.prfusrcod;
            cmd.Parameters.Add("@prfpic", SqlDbType.VarChar, 50).Value = p.prfpic;
            cmd.Parameters.Add("@prfgnd", SqlDbType.Char, 1).Value = p.prfgnd;
            cmd.Parameters.Add("@prfdob", SqlDbType.VarChar, 100).Value = p.prfdob;
            cmd.Parameters.Add("@prfdsc", SqlDbType.VarChar, 500).Value = p.prfdsc;
            cmd.Parameters.Add("@prfloc", SqlDbType.VarChar, 100).Value = p.prfloc;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void update_rec(clsprfprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = p.prfcod;
            cmd.Parameters.Add("@prfusrcod", SqlDbType.Int).Value = p.prfusrcod;
            cmd.Parameters.Add("@prfpic", SqlDbType.VarChar, 50).Value = p.prfpic;
            cmd.Parameters.Add("@prfgnd", SqlDbType.Char, 1).Value = p.prfgnd;
            cmd.Parameters.Add("@prfdob", SqlDbType.VarChar, 100).Value = p.prfdob;
            cmd.Parameters.Add("@prfdsc", SqlDbType.VarChar, 500).Value = p.prfdsc;
            cmd.Parameters.Add("@prfloc", SqlDbType.VarChar, 100).Value = p.prfloc;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void delete_rec(clsprfprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delprf", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = p.prfcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public List<clsprfprp> disp_rec()
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("disprf", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsprfprp> obj = new List<clsprfprp>();
                while (dr.Read())
                {
                    clsprfprp x = new clsprfprp();
                    x.prfcod = Convert.ToInt32(dr[0]);
                    x.prfusrcod = Convert.ToInt32(dr[1]);
                    x.prfpic = dr[2].ToString();
                    x.prfgnd = Convert.ToChar(dr[3]);
                    x.prfdob = dr[4].ToString();
                    x.prfdsc = dr[5].ToString();
                    x.prfloc = dr[6].ToString();
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clsprfprp> find_rec(Int32 prfcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("findprf", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = prfcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsprfprp> obj = new List<clsprfprp>();
                if (dr.HasRows)
                {
                    dr.Read();
                    clsprfprp x = new clsprfprp();
                    x.prfcod = Convert.ToInt32(dr[0]);
                    x.prfusrcod = Convert.ToInt32(dr[1]);
                    x.prfpic = dr[2].ToString();
                    x.prfgnd = Convert.ToChar(dr[3]);
                    x.prfdob = dr[4].ToString();
                    x.prfdsc = dr[5].ToString();
                    x.prfloc = dr[6].ToString();
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
    }
    public class clslst : clscon
    {
        public DataSet dsplstcnt(Int32 usrcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dsplstcnt", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }


        public void Save_Rec(clslstprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inslst", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@lstnam", SqlDbType.VarChar, 100).Value = p.lstnam;
            cmd.Parameters.Add("@lstusrcod", SqlDbType.Int).Value = p.lstusrcod;
            cmd.Parameters.Add("@lstcrtdat", SqlDbType.DateTime).Value = p.lstcrtdat;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void update_Rec(clslstprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updlst", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@lstcod", SqlDbType.Int).Value = p.lstcod;
            cmd.Parameters.Add("@lstnam", SqlDbType.VarChar, 100).Value = p.lstnam;
            cmd.Parameters.Add("@lstusrcod", SqlDbType.Int).Value = p.lstusrcod;
            cmd.Parameters.Add("@lstcrtdat", SqlDbType.DateTime).Value = p.lstcrtdat;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void delete_Rec(clslstprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dellst", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@lstcod", SqlDbType.Int).Value = p.lstcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public List<clslstprp> disp_rec(Int32 usrcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dislst", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clslstprp> obj = new List<clslstprp>();
                while (dr.Read())
                {
                    clslstprp x = new clslstprp();
                    x.lstcod = Convert.ToInt32(dr[0]);
                    x.lstnam = dr[1].ToString();
                    x.lstusrcod = Convert.ToInt32(dr[2]);
                    x.lstcrtdat = Convert.ToDateTime(dr[3]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
        public List<clslstprp> find_rec(Int32 lstcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("findlst", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@lstcod", SqlDbType.Int).Value = lstcod;
                SqlDataReader dr = cmd.ExecuteReader();
               

                List<clslstprp> obj = new List<clslstprp>();
                if (dr.HasRows)
                {
                    dr.Read();
                    clslstprp x = new clslstprp();
                    x.lstcod = Convert.ToInt32(dr[0]);
                    x.lstnam = dr[1].ToString();
                    x.lstusrcod = Convert.ToInt32(dr[2]);
                    x.lstcrtdat = Convert.ToDateTime(dr[3]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }

    }
    public class clsdoc : clscon
    {
        public DataSet dspdocforsal()
        {
    SqlDataAdapter adp = new SqlDataAdapter("dspdocforsal", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public DataSet docshrwit(Int32 doccod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("docshrwit", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@doccod", SqlDbType.Int)
                                    .Value = doccod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }


        public Int32 Save_Rec(clsdocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insdoc", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@doctit", SqlDbType.VarChar, 100).Value = p.doctit;
            cmd.Parameters.Add("@docdsc", SqlDbType.VarChar, 1000).Value = p.docdsc;
            cmd.Parameters.Add("@docfil", SqlDbType.VarChar, 100).Value = p.docfil;
            cmd.Parameters.Add("@doclstcod", SqlDbType.Int).Value = p.doclstcod;
            cmd.Parameters.Add("@docupldat", SqlDbType.DateTime).Value = p.docupldat;
            cmd.Parameters.Add("@docforsalsts", SqlDbType.Char, 1).Value = p.docforsalsts;
            cmd.Parameters.Add("@docprc", SqlDbType.Float).Value = p.docprc;
 cmd.Parameters.Add("@ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@ret"].Value);
            con.Close();
            cmd.Dispose();
            return a;
        }
        public void update_Rec(clsdocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("upddoc", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@doccod", SqlDbType.Int).Value = p.doccod;
            cmd.Parameters.Add("@doctit", SqlDbType.VarChar, 100).Value = p.doctit;
            cmd.Parameters.Add("@docdsc", SqlDbType.VarChar, 1000).Value = p.docdsc;
            cmd.Parameters.Add("@docfil", SqlDbType.VarChar, 100).Value = p.docfil;
            cmd.Parameters.Add("@doclstcod", SqlDbType.Int).Value = p.doclstcod;
            cmd.Parameters.Add("@docupldat", SqlDbType.DateTime).Value = p.docupldat;
            cmd.Parameters.Add("@docforsalsts", SqlDbType.Char, 1).Value = p.docforsalsts;
            cmd.Parameters.Add("@docprc", SqlDbType.Float).Value = p.docprc;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void delete_Rec(clsdocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("deldoc", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@doccod", SqlDbType.Int).Value = p.doccod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }

        public List<clsdocprp> dspmyshrdoc(Int32 usrcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dspmyshrdoc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsdocprp> obj = new List<clsdocprp>();
                while (dr.Read())
                {
                    clsdocprp x = new clsdocprp();
                    x.doccod = Convert.ToInt32(dr[0]);
                    x.doctit = dr[1].ToString();
                    x.docdsc = dr[2].ToString();

                    x.docfil = dr[3].ToString();
                    x.doclstcod = Convert.ToInt32(dr[4]);
                    x.docupldat = Convert.ToDateTime(dr[5]);
                    x.docforsalsts = Convert.ToChar(dr[6]);
                    x.docprc = Convert.ToSingle(dr[7]);

                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clsdocprp> dspmydoc(Int32 usrcod,Int32 lstcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dspmydoc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
                cmd.Parameters.Add("@lstcod", SqlDbType.Int).Value = lstcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsdocprp> obj = new List<clsdocprp>();
                while (dr.Read())
                {
                    clsdocprp x = new clsdocprp();
                    x.doccod = Convert.ToInt32(dr[0]);
                    x.doctit = dr[1].ToString();
                    x.docdsc = dr[2].ToString();

                    x.docfil = dr[3].ToString();
                    x.doclstcod = Convert.ToInt32(dr[4]);
                    x.docupldat = Convert.ToDateTime(dr[5]);
                    x.docforsalsts = Convert.ToChar(dr[6]);
                    x.docprc = Convert.ToSingle(dr[7]);

                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
        public List<clsdocprp> find_rec(Int32 doccod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("finddoc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@doccod", SqlDbType.Int).Value = doccod;
                 SqlDataReader dr = cmd.ExecuteReader();
                List<clsdocprp> obj = new List<clsdocprp>();
                if (dr.HasRows)
                {
                    dr.Read();
                    clsdocprp x = new clsdocprp();
                    x.doccod = Convert.ToInt32(dr[0]);
                    x.doctit = dr[1].ToString();
                    x.docdsc = dr[2].ToString();
                    x.docfil = dr[3].ToString();
                    x.doclstcod = Convert.ToInt32(dr[4]);
                    x.docupldat = Convert.ToDateTime(dr[5]);
                    x.docforsalsts = Convert.ToChar(dr[6]);
                    x.docprc = Convert.ToSingle(dr[7]);

                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }


        }
    }
    public class clsgrp : clscon
    {
        public void Save_Rec(clsgrpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insgrp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@grpnam", SqlDbType.VarChar, 100).Value = p.grpnam;
            cmd.Parameters.Add("@grpdsc", SqlDbType.VarChar, 1000).Value = p.grpdsc;
            cmd.Parameters.Add("@grpcrtdat", SqlDbType.DateTime).Value = p.grpcrtdat;
            cmd.Parameters.Add("@grpownusrcod", SqlDbType.Int).Value = p.grpownusrcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void update_Rec(clsgrpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updgrp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@grpcod", SqlDbType.Int).Value = p.grpcod;
            cmd.Parameters.Add("@grpnam", SqlDbType.VarChar, 100).Value = p.grpnam;
            cmd.Parameters.Add("@grpdsc", SqlDbType.VarChar, 1000).Value = p.grpdsc;
            cmd.Parameters.Add("@grpcrtdat", SqlDbType.DateTime).Value = p.grpcrtdat;
            cmd.Parameters.Add("@grpownusrcod", SqlDbType.Int).Value = p.grpownusrcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void delete_Rec(clsgrpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delgrp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@grpcod", SqlDbType.Int).Value = p.grpcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public List<clsgrpprp> dspmygrp(Int32 usrcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dspmygrp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;

                SqlDataReader dr = cmd.ExecuteReader();
                List<clsgrpprp> obj = new List<clsgrpprp>();
                while (dr.Read())
                {
                    clsgrpprp x = new clsgrpprp();
                    x.grpcod = Convert.ToInt32(dr[0]);
                    x.grpnam = dr[1].ToString();
                    x.grpdsc = dr[2].ToString();
                    x.grpcrtdat = Convert.ToDateTime(dr[3]);
                    x.grpownusrcod = Convert.ToInt32(dr[4]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
        public List<clsgrpprp> find_rec(Int32 grpcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("findgrp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@grpcod", SqlDbType.Int).Value = grpcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsgrpprp> obj = new List<clsgrpprp>();
                if (dr.HasRows)
                {
                    dr.Read();
                    clsgrpprp x = new clsgrpprp();
                    x.grpcod = Convert.ToInt32(dr[0]);
                    x.grpnam = dr[1].ToString();
                    x.grpdsc = dr[2].ToString();
                    x.grpcrtdat = Convert.ToDateTime(dr[3]);
                    x.grpownusrcod = Convert.ToInt32(dr[4]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
    }
    public class clsgrpmem : clscon
    {
        public DataSet dspgrpmem(Int32 grpcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("disgrpmem", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@grpcod", SqlDbType.Int)
                .Value = grpcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public void Save_Rec(clsgrpmemprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insgrpmem", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@grpmemgrpcod", SqlDbType.Int).Value = p.grpmemgrpcod;
            cmd.Parameters.Add("@grpmemusrcod", SqlDbType.Int).Value = p.grpmemusrcod;
            cmd.Parameters.Add("@grpmemjondat", SqlDbType.DateTime).Value = p.grpmemjondat;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void update_Rec(clsgrpmemprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updgrpmem", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@grpmemcod", SqlDbType.Int).Value = p.grpmemcod;
            cmd.Parameters.Add("@grpmemgrpcod", SqlDbType.Int).Value = p.grpmemgrpcod;
            cmd.Parameters.Add("@grpmemusrcod", SqlDbType.Int).Value = p.grpmemusrcod;
            cmd.Parameters.Add("@grpmemjondat", SqlDbType.DateTime).Value = p.grpmemjondat;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void delete_Rec(clsgrpmemprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delgrpmem", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@grpmemcod", SqlDbType.Int).Value = p.grpmemcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public List<clsgrpmemprp> disp_rec()
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("disgrpmem", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsgrpmemprp> obj = new List<clsgrpmemprp>();
                while (dr.Read())
                {
                    clsgrpmemprp x = new clsgrpmemprp();
                    x.grpmemcod = Convert.ToInt32(dr[0]);
                    x.grpmemgrpcod = Convert.ToInt32(dr[1]);
                    x.grpmemusrcod = Convert.ToInt32(dr[2]);
                    x.grpmemjondat = Convert.ToDateTime(dr[3]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
        public List<clsgrpmemprp> find_rec(Int32 grpmemcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("findgrpmem", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@grpmemcod", SqlDbType.Int).Value = grpmemcod;

                SqlDataReader dr = cmd.ExecuteReader();
                List<clsgrpmemprp> obj = new List<clsgrpmemprp>();
                if (dr.HasRows)
                {
                    dr.Read();
                    clsgrpmemprp x = new clsgrpmemprp();
                    x.grpmemcod = Convert.ToInt32(dr[0]);
                    x.grpmemgrpcod = Convert.ToInt32(dr[1]);
                    x.grpmemusrcod = Convert.ToInt32(dr[2]);
                    x.grpmemjondat = Convert.ToDateTime(dr[3]);


                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }

    }
    public class clspst : clscon
    {
        public DataSet dispst(Int32 grpcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dispst", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@grpcod", SqlDbType.Int)
                .Value = grpcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public void Save_Rec(clspstprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inspst", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pstgrpcod", SqlDbType.Int).Value = p.pstgrpcod;
            cmd.Parameters.Add("@pstusrcod", SqlDbType.Int).Value = p.pstusrcod;
            cmd.Parameters.Add("@pstdat", SqlDbType.DateTime).Value = p.pstdat;
            cmd.Parameters.Add("@pstdsc", SqlDbType.VarChar, 1000).Value = p.pstdsc;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void update_rec(clspstprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updpst", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pstcod", SqlDbType.Int).Value = p.pstcod;
            cmd.Parameters.Add("@pstgrpcod", SqlDbType.Int).Value = p.pstgrpcod;
            cmd.Parameters.Add("@pstusrcod", SqlDbType.Int).Value = p.pstusrcod;
            cmd.Parameters.Add("@pstdat", SqlDbType.DateTime).Value = p.pstdat;
            cmd.Parameters.Add("@pstdsc", SqlDbType.VarChar, 1000).Value = p.pstdsc;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void del_rec(clspstprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delpst", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pstcod", SqlDbType.Int).Value = p.pstcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public List<clspstprp> disp_rec()
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispst", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clspstprp> obj = new List<clspstprp>();
                while (dr.Read())
                {
                    clspstprp x = new clspstprp();
                    x.pstcod = Convert.ToInt32(dr[0]);
                    x.pstgrpcod = Convert.ToInt32(dr[1]);
                    x.pstusrcod = Convert.ToInt32(dr[2]);
                    x.pstdat = Convert.ToDateTime(dr[3]);
                    x.pstdsc = dr[4].ToString();


                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
        public List<clspstprp> find_rec(Int32 pstcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("findpst", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pstcod", SqlDbType.Int).Value = pstcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clspstprp> obj = new List<clspstprp>();
                if (dr.HasRows)
                {
                    dr.Read();
                    clspstprp x = new clspstprp();
                    x.pstcod = Convert.ToInt32(dr[0]);
                    x.pstgrpcod = Convert.ToInt32(dr[1]);
                    x.pstusrcod = Convert.ToInt32(dr[2]);
                    x.pstdat = Convert.ToDateTime(dr[3]);
                    x.pstdsc = dr[4].ToString();
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
    }
    public class clsshr : clscon
    {
        public void Save_Rec(clsshrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insshr", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@shrdoc", SqlDbType.Int).Value = p.shrdoc;
            cmd.Parameters.Add("@shrtyp", SqlDbType.Char, 1).Value = p.shrtyp;
            cmd.Parameters.Add("@shrusrcod", SqlDbType.Int).Value = p.shrusrcod;
            cmd.Parameters.Add("@shrgrpcod", SqlDbType.Int).Value = p.shrgrpcod;
            cmd.Parameters.Add("@shrdat", SqlDbType.DateTime).Value = p.shrdat;
            cmd.Parameters.Add("@shrrgt", SqlDbType.Char, 1).Value = p.shrrgt;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();

        }
        public void update_Rec(clsshrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updshr", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@shrcod", SqlDbType.Int).Value = p.shrcod;
            cmd.Parameters.Add("@shrdoc", SqlDbType.Int).Value = p.shrdoc;
            cmd.Parameters.Add("@shrtyp", SqlDbType.Char, 1).Value = p.shrtyp;
            cmd.Parameters.Add("@shrusrcod", SqlDbType.Int).Value = p.shrusrcod;
            cmd.Parameters.Add("@shrgrpcod", SqlDbType.Int).Value = p.shrgrpcod;
            cmd.Parameters.Add("@shrdat", SqlDbType.DateTime).Value = p.shrdat;
            cmd.Parameters.Add("@shrrgt", SqlDbType.Char, 1).Value = p.shrrgt;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();

        }
        public void del_Rec(clsshrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delshr", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@shrcod", SqlDbType.Int).Value = p.shrcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public List<clsshrprp> disp_rec()
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("disshr", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsshrprp> obj = new List<clsshrprp>();
                while (dr.Read())
                {
                    clsshrprp x = new clsshrprp();
                    x.shrcod = Convert.ToInt32(dr[0]);
                    x.shrdoc = Convert.ToInt32(dr[1]);
                    x.shrtyp = Convert.ToChar(dr[2]);
                    x.shrusrcod = Convert.ToInt32(dr[3]);
                    x.shrgrpcod = Convert.ToInt32(dr[4]);
                    x.shrdat = Convert.ToDateTime(dr[5]);
                    x.shrrgt = Convert.ToChar(dr[6]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
        public List<clsshrprp> find_rec(Int32 shrcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("findshr", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@shrcod", SqlDbType.Int).Value = shrcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsshrprp> obj = new List<clsshrprp>();
                if(dr.HasRows)
                {
                    dr.Read();
                    clsshrprp x = new clsshrprp();
                    x.shrcod = Convert.ToInt32(dr[0]);
                    x.shrdoc = Convert.ToInt32(dr[1]);
                    x.shrtyp = Convert.ToChar(dr[2]);
                    x.shrusrcod = Convert.ToInt32(dr[3]);
                    x.shrgrpcod = Convert.ToInt32(dr[4]);
                    x.shrdat = Convert.ToDateTime(dr[5]);
                    x.shrrgt = Convert.ToChar(dr[6]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }

    }
    public class clspur : clscon
    {
        public void Save_Rec(clspurprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inspur", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@purdat", SqlDbType.DateTime).Value = p.purdat;
            cmd.Parameters.Add("@purusrcod", SqlDbType.Int).Value = p.purusrcod;
            cmd.Parameters.Add("@purdoccod", SqlDbType.Int).Value = p.purdoccod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void update_Rec(clspurprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updpur", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@purcod", SqlDbType.Int).Value = p.purcod;
            cmd.Parameters.Add("@purdat", SqlDbType.DateTime).Value = p.purdat;
            cmd.Parameters.Add("@purusrcod", SqlDbType.Int).Value = p.purusrcod;
            cmd.Parameters.Add("@purdoccod", SqlDbType.Int).Value = p.purdoccod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void delete_Rec(clspurprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delpur", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@purcod", SqlDbType.Int).Value = p.purcod;
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public List<clspurprp> disp_rec()
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispur", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clspurprp> obj = new List<clspurprp>();
                while (dr.Read())
                {
                    clspurprp x = new clspurprp();
                    x.purcod = Convert.ToInt32(dr[0]);
                    x.purdat = Convert.ToDateTime(dr[1]);
                    x.purusrcod = Convert.ToInt32(dr[2]);
                    x.purdoccod = Convert.ToInt32(dr[3]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }
        public List<clspurprp> find_rec(Int32 purcod)
        {
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("findpur", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@purcod", SqlDbType.Int).Value = purcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clspurprp> obj = new List<clspurprp>();
               if(dr.HasRows)
                {
                    dr.Read();
                    clspurprp x = new clspurprp();
                    x.purcod = Convert.ToInt32(dr[0]);
                    x.purdat = Convert.ToDateTime(dr[1]);
                    x.purusrcod = Convert.ToInt32(dr[2]);
                    x.purdoccod = Convert.ToInt32(dr[3]);
                    obj.Add(x);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }

        }

    }

#endregion

}









