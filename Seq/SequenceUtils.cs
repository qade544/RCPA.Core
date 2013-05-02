using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RCPA.Seq;
using System.IO;
using RCPA.Utils;
using System.Text.RegularExpressions;

namespace RCPA.Seq
{
  public sealed class SequenceUtils
  {
    public static readonly int DEFAULT_INDEX_LENGTH = 8;

    public static List<string> ReadFastaNames(string filename)
    {
      List<string> result = new List<string>();
      using (StreamReader sr = new StreamReader(filename))
      {
        string line;
        var chars = new char[]{'\t',' '};
        while ((line = sr.ReadLine()) != null)
        {
          if (line.StartsWith(">"))
          {
            var pos = line.IndexOfAny(chars);
            if (pos != -1)
            {
              result.Add(line.Substring(1, pos - 1));
            }
            else
            {
              result.Add(line.Substring(1));
            }
          }
        }
      }
      return result;
    }


    public static List<Sequence> Read(ISequenceFormat sf, string filename)
    {
      List<Sequence> result = new List<Sequence>();
      using (StreamReader sr = new StreamReader(filename))
      {
        Sequence seq;
        while ((seq = sf.ReadSequence(sr)) != null)
        {
          result.Add(seq);
        }
      }
      return result;
    }

    public static Dictionary<string,string> ReadAccessNumberReferenceMap(ISequenceFormat sf, string filename, IAccessNumberParser parser)
    {
      Dictionary<string, string> result = new Dictionary<string, string>();
      using (StreamReader sr = new StreamReader(filename))
      {
        Sequence seq;
        while ((seq = sf.ReadSequence(sr)) != null)
        {
          result[parser.GetValue(seq.Name)] = seq.Reference;
        }
      }
      return result;
    }

    public static void Write(ISequenceFormat sf, string filename, IEnumerable<Sequence> seqs)
    {
      using (StreamWriter sw = new StreamWriter(filename))
      {
        foreach (Sequence seq in seqs)
        {
          sf.WriteSequence(sw, seq);
        }
      }
    }

    public static string GetReversedSequence(string sequence)
    {
      StringBuilder sb = new StringBuilder();
      for (int i = sequence.Length - 1; i >= 0; i--)
      {
        sb.Append(sequence[i]);
      }
      return sb.ToString();
    }

    public static Sequence GetReversedSequence(string sequence, int index)
    {
      return GetReversedSequence(sequence, "REVERSED_", DEFAULT_INDEX_LENGTH, index);
    }

    public static Sequence GetReversedSequence(string sequence, int indexLength, int index)
    {
      return GetReversedSequence(sequence, "REVERSED_", indexLength, index);
    }
    
    public static Sequence GetReversedSequence(string sequence, string prefix, int indexLength, int index)
    {
      return new Sequence(prefix + StringUtils.LeftFill(index, indexLength, '0'), GetReversedSequence(sequence));
    }

    public static Dictionary<char, double> GetDatabaseComposition(string fastaFile)
    {
      Dictionary<char, double> result = new Dictionary<char, double>();
      using (StreamReader sr = new StreamReader(fastaFile))
      {
        FastaFormat ff = new FastaFormat();
        Sequence seq;
        while ((seq = ff.ReadSequence(sr)) != null)
        {
          foreach (char c in seq.SeqString)
          {
            if (result.ContainsKey(c))
            {
              result[c] = result[c] + 1;
            }
            else
            {
              result[c] = 1;
            }
          }
        }

        double total = result.Values.Sum();
        
        foreach (char c in result.Keys.ToArray())
        {
          result[c] = result[c] / total;
        }
      }
      return result;
    }

    public static string ToAnotherStrand(string seq)
    {
      StringBuilder result = new StringBuilder();
      for (int i = seq.Length - 1; i >= 0; i--)
      {
        var c = seq[i];
        if (c == 'A')
        {
          result.Append('T');
        }
        else if (c == 'T')
        {
          result.Append('A');
        }
        else if (c == 'G')
        {
          result.Append('C');
        }
        else if (c == 'C')
        {
          result.Append('G');
        }
        else if (c == 'N')
        {
          result.Append(c);
        }
        else if (c == 'a')
        {
          result.Append('t');
        }
        else if (c == 't')
        {
          result.Append('a');
        }
        else if (c == 'g')
        {
          result.Append('c');
        }
        else if (c == 'c')
        {
          result.Append('g');
        }
        else if (c == 'n')
        {
          result.Append(c);
        }
        else
        {
          Console.WriteLine("bp = {0}", c);
          result.Append(c);
        }
      }
      return result.ToString();
    }
  }
}