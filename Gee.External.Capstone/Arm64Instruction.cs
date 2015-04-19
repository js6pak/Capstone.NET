﻿// ReSharper disable InconsistentNaming

namespace Gee.External.Capstone {
    /// <summary>
    ///     ARM64 Instruction.
    /// </summary>
    public enum Arm64Instruction {
        /// <summary>
        ///     Invalid Instruction.
        /// </summary>
        Invalid = 0,

        ABS,
        ADC,
        ADDHN,
        ADDHN2,
        ADDP,
        ADD,
        ADDV,
        ADR,
        ADRP,
        AESD,
        AESE,
        AESIMC,
        AESMC,
        AND,
        ASR,
        B,
        BFM,
        BIC,
        BIF,
        BIT,
        BL,
        BLR,
        BR,
        BRK,
        BSL,
        CBNZ,
        CBZ,
        CCMN,
        CCMP,
        CLREX,
        CLS,
        CLZ,
        CMEQ,
        CMGE,
        CMGT,
        CMHI,
        CMHS,
        CMLE,
        CMLT,
        CMTST,
        CNT,
        MOV,
        CRC32B,
        CRC32CB,
        CRC32CH,
        CRC32CW,
        CRC32CX,
        CRC32H,
        CRC32W,
        CRC32X,
        CSEL,
        CSINC,
        CSINV,
        CSNEG,
        DCPS1,
        DCPS2,
        DCPS3,
        DMB,
        DRPS,
        DSB,
        DUP,
        EON,
        EOR,
        ERET,
        EXTR,
        EXT,
        FABD,
        FABS,
        FACGE,
        FACGT,
        FADD,
        FADDP,
        FCCMP,
        FCCMPE,
        FCMEQ,
        FCMGE,
        FCMGT,
        FCMLE,
        FCMLT,
        FCMP,
        FCMPE,
        FCSEL,
        FCVTAS,
        FCVTAU,
        FCVT,
        FCVTL,
        FCVTL2,
        FCVTMS,
        FCVTMU,
        FCVTNS,
        FCVTNU,
        FCVTN,
        FCVTN2,
        FCVTPS,
        FCVTPU,
        FCVTXN,
        FCVTXN2,
        FCVTZS,
        FCVTZU,
        FDIV,
        FMADD,
        FMAX,
        FMAXNM,
        FMAXNMP,
        FMAXNMV,
        FMAXP,
        FMAXV,
        FMIN,
        FMINNM,
        FMINNMP,
        FMINNMV,
        FMINP,
        FMINV,
        FMLA,
        FMLS,
        FMOV,
        FMSUB,
        FMUL,
        FMULX,
        FNEG,
        FNMADD,
        FNMSUB,
        FNMUL,
        FRECPE,
        FRECPS,
        FRECPX,
        FRINTA,
        FRINTI,
        FRINTM,
        FRINTN,
        FRINTP,
        FRINTX,
        FRINTZ,
        FRSQRTE,
        FRSQRTS,
        FSQRT,
        FSUB,
        HINT,
        HLT,
        HVC,
        INS,
        ISB,
        LD1,
        LD1R,
        LD2R,
        LD2,
        LD3R,
        LD3,
        LD4,
        LD4R,
        LDARB,
        LDARH,
        LDAR,
        LDAXP,
        LDAXRB,
        LDAXRH,
        LDAXR,
        LDNP,
        LDP,
        LDPSW,
        LDRB,
        LDR,
        LDRH,
        LDRSB,
        LDRSH,
        LDRSW,
        LDTRB,
        LDTRH,
        LDTRSB,
        LDTRSH,
        LDTRSW,
        LDTR,
        LDURB,
        LDUR,
        LDURH,
        LDURSB,
        LDURSH,
        LDURSW,
        LDXP,
        LDXRB,
        LDXRH,
        LDXR,
        LSL,
        LSR,
        MADD,
        MLA,
        MLS,
        MOVI,
        MOVK,
        MOVN,
        MOVZ,
        MRS,
        MSR,
        MSUB,
        MUL,
        MVNI,
        NEG,
        NOT,
        ORN,
        ORR,
        PMULL2,
        PMULL,
        PMUL,
        PRFM,
        PRFUM,
        RADDHN,
        RADDHN2,
        RBIT,
        RET,
        REV16,
        REV32,
        REV64,
        REV,
        ROR,
        RSHRN2,
        RSHRN,
        RSUBHN,
        RSUBHN2,
        SABAL2,
        SABAL,
        SABA,
        SABDL2,
        SABDL,
        SABD,
        SADALP,
        SADDLP,
        SADDLV,
        SADDL2,
        SADDL,
        SADDW2,
        SADDW,
        SBC,
        SBFM,
        SCVTF,
        SDIV,
        SHA1C,
        SHA1H,
        SHA1M,
        SHA1P,
        SHA1SU0,
        SHA1SU1,
        SHA256H2,
        SHA256H,
        SHA256SU0,
        SHA256SU1,
        SHADD,
        SHLL2,
        SHLL,
        SHL,
        SHRN2,
        SHRN,
        SHSUB,
        SLI,
        SMADDL,
        SMAXP,
        SMAXV,
        SMAX,
        SMC,
        SMINP,
        SMINV,
        SMIN,
        SMLAL2,
        SMLAL,
        SMLSL2,
        SMLSL,
        SMOV,
        SMSUBL,
        SMULH,
        SMULL2,
        SMULL,
        SQABS,
        SQADD,
        SQDMLAL,
        SQDMLAL2,
        SQDMLSL,
        SQDMLSL2,
        SQDMULH,
        SQDMULL,
        SQDMULL2,
        SQNEG,
        SQRDMULH,
        SQRSHL,
        SQRSHRN,
        SQRSHRN2,
        SQRSHRUN,
        SQRSHRUN2,
        SQSHLU,
        SQSHL,
        SQSHRN,
        SQSHRN2,
        SQSHRUN,
        SQSHRUN2,
        SQSUB,
        SQXTN2,
        SQXTN,
        SQXTUN2,
        SQXTUN,
        SRHADD,
        SRI,
        SRSHL,
        SRSHR,
        SRSRA,
        SSHLL2,
        SSHLL,
        SSHL,
        SSHR,
        SSRA,
        SSUBL2,
        SSUBL,
        SSUBW2,
        SSUBW,
        ST1,
        ST2,
        ST3,
        ST4,
        STLRB,
        STLRH,
        STLR,
        STLXP,
        STLXRB,
        STLXRH,
        STLXR,
        STNP,
        STP,
        STRB,
        STR,
        STRH,
        STTRB,
        STTRH,
        STTR,
        STURB,
        STUR,
        STURH,
        STXP,
        STXRB,
        STXRH,
        STXR,
        SUBHN,
        SUBHN2,
        SUB,
        SUQADD,
        SVC,
        SYSL,
        SYS,
        TBL,
        TBNZ,
        TBX,
        TBZ,
        TRN1,
        TRN2,
        UABAL2,
        UABAL,
        UABA,
        UABDL2,
        UABDL,
        UABD,
        UADALP,
        UADDLP,
        UADDLV,
        UADDL2,
        UADDL,
        UADDW2,
        UADDW,
        UBFM,
        UCVTF,
        UDIV,
        UHADD,
        UHSUB,
        UMADDL,
        UMAXP,
        UMAXV,
        UMAX,
        UMINP,
        UMINV,
        UMIN,
        UMLAL2,
        UMLAL,
        UMLSL2,
        UMLSL,
        UMOV,
        UMSUBL,
        UMULH,
        UMULL2,
        UMULL,
        UQADD,
        UQRSHL,
        UQRSHRN,
        UQRSHRN2,
        UQSHL,
        UQSHRN,
        UQSHRN2,
        UQSUB,
        UQXTN2,
        UQXTN,
        URECPE,
        URHADD,
        URSHL,
        URSHR,
        URSQRTE,
        URSRA,
        USHLL2,
        USHLL,
        USHL,
        USHR,
        USQADD,
        USRA,
        USUBL2,
        USUBL,
        USUBW2,
        USUBW,
        UZP1,
        UZP2,
        XTN2,
        XTN,
        ZIP1,
        ZIP2,
        MNEG,
        UMNEGL,
        SMNEGL,
        NOP,
        YIELD,
        WFE,
        WFI,
        SEV,
        SEVL,
        NGC,
        SBFIZ,
        UBFIZ,
        SBFX,
        UBFX,
        BFI,
        BFXIL,
        CMN,
        MVN,
        TST,
        CSET,
        CINC,
        CSETM,
        CINV,
        CNEG,
        SXTB,
        SXTH,
        SXTW,
        CMP,
        UXTB,
        UXTH,
        UXTW,
        IC,
        DC,
        AT,
        TLBI
    }
}