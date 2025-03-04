﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    public enum AnimStatus{
        Pause=0,
        Forward,
        Rewind,
        PrePlay,
        Disk
    }
    public enum SliderMode{
        Normal=0,
        Jump
    }
    public enum GraphType{
        Type0=0,
        Type1,
        Type2,
        Type3,
        Type4
    }
    public enum PacketType{
        Normal=0,
        Parity,
        MCD,
        MCDcache,
        HC,
        TCP,
        ICMP,
        NAK,
        Tunnel,
        Qos,
        HTTP2
    }
    public enum ColorPattern{
        OriginBased=0,
        RequestReply,
        PathBased,
        None,
    }

    public enum PacketTag{
        N=0,
        F,
        R
    }

    public static string chosanExperimentName;
    public static string experimentYaml;
    public static string configYaml;
    public static string images;
    public static string introConfigYaml;
    public static string experimentMetadata;
    public static string animTimeFile;
    public static float gVar = 10;
    public const float U_SEC = 1000000f;
    public const bool PRE_PLAY = false;
    public const float MAX_SPEED = 3f;
    public const int showAnimation = 1; 
}
