namespace System.Reflection.Metadata.ILReader
{
  public partial class ILReaderImpl
  {
    public static unsafe Instruction[] ReadUnsafe(BlobReader reader, int count)
    {
      var instructions1 = new Instruction[count];
      fixed (Instruction* instructions = instructions1)

      for (var index = 0; index < count; index++)

      //for (var index = 0; index < instructions.Length; index++)
      {
        switch (reader.ReadByte())
        {
          case 0x00: // nop
            instructions[index].myCode = Opcode.Nop;
            continue;
          case 0x01: // break
            instructions[index].myCode = Opcode.Break;
            continue;
          case 0x02: // ldarg.0
            instructions[index].myCode = Opcode.Ldarg;
            instructions[index].myIntOperand = 0;
            continue;
          case 0x03: // ldarg.1
            instructions[index].myCode = Opcode.Ldarg;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x04: // ldarg.2
            instructions[index].myCode = Opcode.Ldarg;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x05: // ldarg.3
            instructions[index].myCode = Opcode.Ldarg;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x06: // ldloc.0
            instructions[index].myCode = Opcode.Ldloc;
            instructions[index].myIntOperand = 0;
            continue;
          case 0x07: // ldloc.1
            instructions[index].myCode = Opcode.Ldloc;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x08: // ldloc.2
            instructions[index].myCode = Opcode.Ldloc;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x09: // ldloc.3
            instructions[index].myCode = Opcode.Ldloc;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x0A: // stloc.0
            instructions[index].myCode = Opcode.Stloc;
            instructions[index].myIntOperand = 0;
            continue;
          case 0x0B: // stloc.1
            instructions[index].myCode = Opcode.Stloc;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x0C: // stloc.2
            instructions[index].myCode = Opcode.Stloc;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x0D: // stloc.3
            instructions[index].myCode = Opcode.Stloc;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x0E: // ldarg.s
            instructions[index].myCode = Opcode.Ldarg;
            instructions[index].myIntOperand = reader.ReadByte();
            continue;
          case 0x0F: // ldarga.s
            instructions[index].myCode = Opcode.Ldarga;
            instructions[index].myIntOperand = reader.ReadByte();
            continue;
          case 0x10: // starg.s
            instructions[index].myCode = Opcode.Starg;
            instructions[index].myIntOperand = reader.ReadByte();
            continue;
          case 0x11: // ldloc.s
            instructions[index].myCode = Opcode.Ldloc;
            instructions[index].myIntOperand = reader.ReadByte();
            continue;
          case 0x12: // ldloca.s
            instructions[index].myCode = Opcode.Ldloca;
            instructions[index].myIntOperand = reader.ReadByte();
            continue;
          case 0x13: // stloc.s
            instructions[index].myCode = Opcode.Stloc;
            instructions[index].myIntOperand = reader.ReadByte();
            continue;
          case 0x14: // ldnull
            instructions[index].myCode = Opcode.Ldnull;
            continue;
          case 0x15: // ldc.i4.m1
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = -1;
            continue;
          case 0x16: // ldc.i4.0
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 0;
            continue;
          case 0x17: // ldc.i4.1
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x18: // ldc.i4.2
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x19: // ldc.i4.3
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x1A: // ldc.i4.4
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 4;
            continue;
          case 0x1B: // ldc.i4.5
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 5;
            continue;
          case 0x1C: // ldc.i4.6
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 6;
            continue;
          case 0x1D: // ldc.i4.7
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 7;
            continue;
          case 0x1E: // ldc.i4.8
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = 8;
            continue;
          case 0x1F: // ldc.i4.s
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = reader.ReadByte();
            continue;
          case 0x20: // ldc.i4
            instructions[index].myCode = Opcode.LdcI4;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x21: // ldc.i8
            instructions[index].myCode = Opcode.LdcI8;
            //instructions[index].myOperand = reader.ReadInt64();
            continue;
          case 0x22: // ldc.r4
            instructions[index].myCode = Opcode.LdcR4;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x23: // ldc.r8
            instructions[index].myCode = Opcode.LdcR8;
            //instructions[index].myOperand = reader.ReadInt64();
            continue;
          case 0x25: // dup
            instructions[index].myCode = Opcode.Dup;
            continue;
          case 0x26: // pop
            instructions[index].myCode = Opcode.Pop;
            continue;
          case 0x27: // jmp
            instructions[index].myCode = Opcode.Jmp;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x28: // call
            instructions[index].myCode = Opcode.Call;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x29: // calli
            instructions[index].myCode = Opcode.Calli;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x2A: // ret
            instructions[index].myCode = Opcode.Ret;
            continue;
          case 0x2B: // br.s
            instructions[index].myCode = Opcode.Br;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x2C: // brfalse.s
            instructions[index].myCode = Opcode.Brfalse;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x2D: // brtrue.s
            instructions[index].myCode = Opcode.Brtrue;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x2E: // beq.s
            instructions[index].myCode = Opcode.Beq;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x2F: // bge.s
            instructions[index].myCode = Opcode.Bge;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x30: // bgt.s
            instructions[index].myCode = Opcode.Bgt;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x31: // ble.s
            instructions[index].myCode = Opcode.Ble;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x32: // blt.s
            instructions[index].myCode = Opcode.Blt;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x33: // bne.un.s
            instructions[index].myCode = Opcode.BneUn;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x34: // bge.un.s
            instructions[index].myCode = Opcode.BgeUn;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x35: // bgt.un.s
            instructions[index].myCode = Opcode.BgtUn;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x36: // ble.un.s
            instructions[index].myCode = Opcode.BleUn;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x37: // blt.un.s
            instructions[index].myCode = Opcode.BltUn;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0x38: // br
            instructions[index].myCode = Opcode.Br;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x39: // brfalse
            instructions[index].myCode = Opcode.Brfalse;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x3A: // brtrue
            instructions[index].myCode = Opcode.Brtrue;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x3B: // beq
            instructions[index].myCode = Opcode.Beq;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x3C: // bge
            instructions[index].myCode = Opcode.Bge;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x3D: // bgt
            instructions[index].myCode = Opcode.Bgt;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x3E: // ble
            instructions[index].myCode = Opcode.Ble;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x3F: // blt
            instructions[index].myCode = Opcode.Blt;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x40: // bne.un
            instructions[index].myCode = Opcode.BneUn;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x41: // bge.un
            instructions[index].myCode = Opcode.BgeUn;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x42: // bgt.un
            instructions[index].myCode = Opcode.BgtUn;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x43: // ble.un
            instructions[index].myCode = Opcode.BleUn;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x44: // blt.un
            instructions[index].myCode = Opcode.BltUn;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0x45: // switch
            instructions[index].myCode = Opcode.Switch;
            //instructions[index].myOperand = ReadSwitch(ref reader);
            continue;
          case 0x46: // ldind.i1
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x47: // ldind.u1
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 5;
            continue;
          case 0x48: // ldind.i2
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x49: // ldind.u2
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 6;
            continue;
          case 0x4A: // ldind.i4
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x4B: // ldind.u4
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 7;
            continue;
          case 0x4C: // ldind.i8
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 4;
            continue;
          case 0x4D: // ldind.i
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 0;
            continue;
          case 0x4E: // ldind.r4
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 9;
            continue;
          case 0x4F: // ldind.r8
            instructions[index].myCode = Opcode.Ldind;
            instructions[index].myIntOperand = 10;
            continue;
          case 0x50: // ldind.ref
            instructions[index].myCode = Opcode.LdindRef;
            continue;
          case 0x51: // stind.ref
            instructions[index].myCode = Opcode.StindRef;
            continue;
          case 0x52: // stind.i1
            instructions[index].myCode = Opcode.Stind;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x53: // stind.i2
            instructions[index].myCode = Opcode.Stind;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x54: // stind.i4
            instructions[index].myCode = Opcode.Stind;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x55: // stind.i8
            instructions[index].myCode = Opcode.Stind;
            instructions[index].myIntOperand = 4;
            continue;
          case 0x56: // stind.r4
            instructions[index].myCode = Opcode.Stind;
            instructions[index].myIntOperand = 9;
            continue;
          case 0x57: // stind.r8
            instructions[index].myCode = Opcode.Stind;
            instructions[index].myIntOperand = 10;
            continue;
          case 0x58: // add
            instructions[index].myCode = Opcode.Add;
            continue;
          case 0x59: // sub
            instructions[index].myCode = Opcode.Sub;
            continue;
          case 0x5A: // mul
            instructions[index].myCode = Opcode.Mul;
            continue;
          case 0x5B: // div
            instructions[index].myCode = Opcode.Div;
            continue;
          case 0x5C: // div.un
            instructions[index].myCode = Opcode.DivUn;
            continue;
          case 0x5D: // rem
            instructions[index].myCode = Opcode.Rem;
            continue;
          case 0x5E: // rem.un
            instructions[index].myCode = Opcode.RemUn;
            continue;
          case 0x5F: // and
            instructions[index].myCode = Opcode.And;
            continue;
          case 0x60: // or
            instructions[index].myCode = Opcode.Or;
            continue;
          case 0x61: // xor
            instructions[index].myCode = Opcode.Xor;
            continue;
          case 0x62: // shl
            instructions[index].myCode = Opcode.Shl;
            continue;
          case 0x63: // shr
            instructions[index].myCode = Opcode.Shr;
            continue;
          case 0x64: // shr.un
            instructions[index].myCode = Opcode.ShrUn;
            continue;
          case 0x65: // neg
            instructions[index].myCode = Opcode.Neg;
            continue;
          case 0x66: // not
            instructions[index].myCode = Opcode.Not;
            continue;
          case 0x67: // conv.i1
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x68: // conv.i2
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x69: // conv.i4
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x6A: // conv.i8
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 4;
            continue;
          case 0x6B: // conv.r4
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 9;
            continue;
          case 0x6C: // conv.r8
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 10;
            continue;
          case 0x6D: // conv.u4
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 7;
            continue;
          case 0x6E: // conv.u8
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 8;
            continue;
          case 0x6F: // callvirt
            instructions[index].myCode = Opcode.Callvirt;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x70: // cpobj
            instructions[index].myCode = Opcode.Cpobj;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x71: // ldobj
            instructions[index].myCode = Opcode.Ldobj;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x72: // ldstr
            instructions[index].myCode = Opcode.Ldstr;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x73: // newobj
            instructions[index].myCode = Opcode.Newobj;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x74: // castclass
            instructions[index].myCode = Opcode.Castclass;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x75: // isinst
            instructions[index].myCode = Opcode.Isinst;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x76: // conv.r.un
            instructions[index].myCode = Opcode.ConvUn;
            instructions[index].myIntOperand = 9;
            continue;
          case 0x79: // unbox
            instructions[index].myCode = Opcode.Unbox;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x7A: // throw
            instructions[index].myCode = Opcode.Throw;
            continue;
          case 0x7B: // ldfld
            instructions[index].myCode = Opcode.Ldfld;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x7C: // ldflda
            instructions[index].myCode = Opcode.Ldflda;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x7D: // stfld
            instructions[index].myCode = Opcode.Stfld;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x7E: // ldsfld
            instructions[index].myCode = Opcode.Ldsfld;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x7F: // ldsflda
            instructions[index].myCode = Opcode.Ldsflda;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x80: // stsfld
            instructions[index].myCode = Opcode.Stsfld;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x81: // stobj
            instructions[index].myCode = Opcode.Stobj;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x82: // conv.ovf.i1.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x83: // conv.ovf.i2.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x84: // conv.ovf.i4.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x85: // conv.ovf.i8.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 4;
            continue;
          case 0x86: // conv.ovf.u1.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 5;
            continue;
          case 0x87: // conv.ovf.u2.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 6;
            continue;
          case 0x88: // conv.ovf.u4.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 7;
            continue;
          case 0x89: // conv.ovf.u8.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 8;
            continue;
          case 0x8A: // conv.ovf.i.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 0;
            continue;
          case 0x8B: // conv.ovf.u.un
            instructions[index].myCode = Opcode.ConvOvfUn;
            instructions[index].myIntOperand = 11;
            continue;
          case 0x8C: // box
            instructions[index].myCode = Opcode.Box;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x8D: // newarr
            instructions[index].myCode = Opcode.Newarr;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x8E: // ldlen
            instructions[index].myCode = Opcode.Ldlen;
            continue;
          case 0x8F: // ldelema
            instructions[index].myCode = Opcode.Ldelema;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0x90: // ldelem.i1
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x91: // ldelem.u1
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 5;
            continue;
          case 0x92: // ldelem.i2
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x93: // ldelem.u2
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 6;
            continue;
          case 0x94: // ldelem.i4
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x95: // ldelem.u4
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 7;
            continue;
          case 0x96: // ldelem.i8
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 4;
            continue;
          case 0x97: // ldelem.i
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 0;
            continue;
          case 0x98: // ldelem.r4
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 9;
            continue;
          case 0x99: // ldelem.r8
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = 10;
            continue;
          case 0x9A: // ldelem.ref
            instructions[index].myCode = Opcode.LdelemRef;
            continue;
          case 0x9B: // stelem.i
            instructions[index].myCode = Opcode.Stelem;
            instructions[index].myIntOperand = 0;
            continue;
          case 0x9C: // stelem.i1
            instructions[index].myCode = Opcode.Stelem;
            instructions[index].myIntOperand = 1;
            continue;
          case 0x9D: // stelem.i2
            instructions[index].myCode = Opcode.Stelem;
            instructions[index].myIntOperand = 2;
            continue;
          case 0x9E: // stelem.i4
            instructions[index].myCode = Opcode.Stelem;
            instructions[index].myIntOperand = 3;
            continue;
          case 0x9F: // stelem.i8
            instructions[index].myCode = Opcode.Stelem;
            instructions[index].myIntOperand = 4;
            continue;
          case 0xA0: // stelem.r4
            instructions[index].myCode = Opcode.Stelem;
            instructions[index].myIntOperand = 9;
            continue;
          case 0xA1: // stelem.r8
            instructions[index].myCode = Opcode.Stelem;
            instructions[index].myIntOperand = 10;
            continue;
          case 0xA2: // stelem.ref
            instructions[index].myCode = Opcode.StelemRef;
            continue;
          case 0xA3: // ldelem
            instructions[index].myCode = Opcode.Ldelem;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0xA4: // stelem
            instructions[index].myCode = Opcode.Stelem;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0xA5: // unbox.any
            instructions[index].myCode = Opcode.UnboxAny;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0xB3: // conv.ovf.i1
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 1;
            continue;
          case 0xB4: // conv.ovf.u1
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 5;
            continue;
          case 0xB5: // conv.ovf.i2
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 2;
            continue;
          case 0xB6: // conv.ovf.u2
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 6;
            continue;
          case 0xB7: // conv.ovf.i4
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 3;
            continue;
          case 0xB8: // conv.ovf.u4
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 7;
            continue;
          case 0xB9: // conv.ovf.i8
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 4;
            continue;
          case 0xBA: // conv.ovf.u8
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 8;
            continue;
          case 0xC2: // refanyval
            instructions[index].myCode = Opcode.Refanyval;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0xC3: // ckfinite
            instructions[index].myCode = Opcode.Ckfinite;
            continue;
          case 0xC6: // mkrefany
            instructions[index].myCode = Opcode.Mkrefany;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0xD0: // ldtoken
            instructions[index].myCode = Opcode.Ldtoken;
            instructions[index].myIntOperand = reader.ReadInt32();
            continue;
          case 0xD1: // conv.u2
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 6;
            continue;
          case 0xD2: // conv.u1
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 5;
            continue;
          case 0xD3: // conv.i
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 0;
            continue;
          case 0xD4: // conv.ovf.i
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 0;
            continue;
          case 0xD5: // conv.ovf.u
            instructions[index].myCode = Opcode.ConvOvf;
            instructions[index].myIntOperand = 11;
            continue;
          case 0xD6: // add.ovf
            instructions[index].myCode = Opcode.AddOvf;
            continue;
          case 0xD7: // add.ovf.un
            instructions[index].myCode = Opcode.AddOvfUn;
            continue;
          case 0xD8: // mul.ovf
            instructions[index].myCode = Opcode.MulOvf;
            continue;
          case 0xD9: // mul.ovf.un
            instructions[index].myCode = Opcode.MulOvfUn;
            continue;
          case 0xDA: // sub.ovf
            instructions[index].myCode = Opcode.SubOvf;
            continue;
          case 0xDB: // sub.ovf.un
            instructions[index].myCode = Opcode.SubOvfUn;
            continue;
          case 0xDC: // endfinally
            instructions[index].myCode = Opcode.Endfinally;
            continue;
          case 0xDD: // leave
            instructions[index].myCode = Opcode.Leave;
            instructions[index].myIntOperand = reader.ReadInt32() + reader.Offset;
            continue;
          case 0xDE: // leave.s
            instructions[index].myCode = Opcode.Leave;
            instructions[index].myIntOperand = reader.ReadSByte() + reader.Offset;
            continue;
          case 0xDF: // stind.i
            instructions[index].myCode = Opcode.Stind;
            instructions[index].myIntOperand = 0;
            continue;
          case 0xE0: // conv.u
            instructions[index].myCode = Opcode.Conv;
            instructions[index].myIntOperand = 11;
            continue;
          case 0xF8: // prefix7
            instructions[index].myCode = Opcode.Prefix7;
            continue;
          case 0xF9: // prefix6
            instructions[index].myCode = Opcode.Prefix6;
            continue;
          case 0xFA: // prefix5
            instructions[index].myCode = Opcode.Prefix5;
            continue;
          case 0xFB: // prefix4
            instructions[index].myCode = Opcode.Prefix4;
            continue;
          case 0xFC: // prefix3
            instructions[index].myCode = Opcode.Prefix3;
            continue;
          case 0xFD: // prefix2
            instructions[index].myCode = Opcode.Prefix2;
            continue;
          case 0xFF: // prefixref
            instructions[index].myCode = Opcode.Prefixref;
            continue;
          case 0xFE:
            switch (reader.ReadByte())
            {
              case 0x00: // arglist
                instructions[index].myCode = Opcode.Arglist;
                continue;
              case 0x01: // ceq
                instructions[index].myCode = Opcode.Ceq;
                continue;
              case 0x02: // cgt
                instructions[index].myCode = Opcode.Cgt;
                continue;
              case 0x03: // cgt.un
                instructions[index].myCode = Opcode.CgtUn;
                continue;
              case 0x04: // clt
                instructions[index].myCode = Opcode.Clt;
                continue;
              case 0x05: // clt.un
                instructions[index].myCode = Opcode.CltUn;
                continue;
              case 0x06: // ldftn
                instructions[index].myCode = Opcode.Ldftn;
                instructions[index].myIntOperand = reader.ReadInt32();
                continue;
              case 0x07: // ldvirtftn
                instructions[index].myCode = Opcode.Ldvirtftn;
                instructions[index].myIntOperand = reader.ReadInt32();
                continue;
              case 0x09: // ldarg
                instructions[index].myCode = Opcode.Ldarg;
                instructions[index].myIntOperand = reader.ReadInt16();
                continue;
              case 0x0A: // ldarga
                instructions[index].myCode = Opcode.Ldarga;
                instructions[index].myIntOperand = reader.ReadInt16();
                continue;
              case 0x0B: // starg
                instructions[index].myCode = Opcode.Starg;
                instructions[index].myIntOperand = reader.ReadInt16();
                continue;
              case 0x0C: // ldloc
                instructions[index].myCode = Opcode.Ldloc;
                instructions[index].myIntOperand = reader.ReadInt16();
                continue;
              case 0x0D: // ldloca
                instructions[index].myCode = Opcode.Ldloca;
                instructions[index].myIntOperand = reader.ReadInt16();
                continue;
              case 0x0E: // stloc
                instructions[index].myCode = Opcode.Stloc;
                instructions[index].myIntOperand = reader.ReadInt16();
                continue;
              case 0x0F: // localloc
                instructions[index].myCode = Opcode.Localloc;
                continue;
              case 0x11: // endfilter
                instructions[index].myCode = Opcode.Endfilter;
                continue;
              case 0x12: // unaligned.
                instructions[index].myCode = Opcode.Unaligned;
                instructions[index].myIntOperand = reader.ReadByte();
                continue;
              case 0x13: // volatile.
                instructions[index].myCode = Opcode.Volatile;
                continue;
              case 0x14: // tail.
                instructions[index].myCode = Opcode.Tail;
                continue;
              case 0x15: // initobj
                instructions[index].myCode = Opcode.Initobj;
                instructions[index].myIntOperand = reader.ReadInt32();
                continue;
              case 0x16: // constrained.
                instructions[index].myCode = Opcode.Constrained;
                instructions[index].myIntOperand = reader.ReadInt32();
                continue;
              case 0x17: // cpblk
                instructions[index].myCode = Opcode.Cpblk;
                continue;
              case 0x18: // initblk
                instructions[index].myCode = Opcode.Initblk;
                continue;
              case 0x1A: // rethrow
                instructions[index].myCode = Opcode.Rethrow;
                continue;
              case 0x1C: // sizeof
                instructions[index].myCode = Opcode.Sizeof;
                instructions[index].myIntOperand = reader.ReadInt32();
                continue;
              case 0x1D: // refanytype
                instructions[index].myCode = Opcode.Refanytype;
                continue;
              case 0x1E: // readonly.
                instructions[index].myCode = Opcode.Readonly;
                continue;
              default:
                continue;
            }
          default:
            continue;
        }
      }

      return instructions1;
    }
  }
}