﻿// Decompiled with JetBrains decompiler
// Type: ExitGames.Client.Photon.Hashtable
// Assembly: Photon3Unity3D, Version=4.0.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 45094ECB-AE08-4341-BE26-E524C8B0C677
// Assembly location: D:\Development\Attack on Titan\Assemblies\Photon3Unity3D.dll

using System.Collections;
using System.Collections.Generic;

namespace ExitGames.Client.Photon
{
  public class Hashtable : Dictionary<object, object>
  {
    private DictionaryEntryEnumerator enumerator;

    public Hashtable()
    {
    }

    public Hashtable(int x)
      : base(x)
    {
    }

    public new object this[object key]
    {
      get
      {
        object obj = (object) null;
        this.TryGetValue(key, out obj);
        return obj;
      }
      set
      {
        base[key] = value;
      }
    }

    public IEnumerator<DictionaryEntry> GetEnumerator()
    {
      return this.GetEnumerator();
    }

    public override string ToString()
    {
      List<string> stringList = new List<string>();
      foreach (object key in this.Keys)
        stringList.Add("(" + (object) key.GetType() + ")" + key + "=(" + (object) this[key].GetType() + ")" + this[key]);
      return string.Join(", ", stringList.ToArray());
    }

    public object Clone()
    {
      return (object) new Dictionary<object, object>((IDictionary<object, object>) this);
    }
  }
}
