namespace IF97
{
    public enum IF97Parameters
    {
        /// <summary>
        /// density ρ 密度
        /// </summary>
        d,

        /// <summary>
        /// specific enthalpy 比焓.
        /// </summary>
        h,

        /// <summary>
        /// absolute temperature  绝对温度.
        /// </summary>
        T,

        /// <summary>
        /// pressure  压力.
        /// </summary>
        p,

        /// <summary>
        /// specific entropy  比熵.
        /// </summary>
        s,

        /// <summary>
        /// 比内能.
        /// </summary>
        u,

        /// <summary>
        /// specific internal energy 比体积
        /// </summary>
        v,

        /// <summary>
        /// isobaric specific heat 等压比热
        /// </summary>
        cp,

        /// <summary>
        /// sovolumetric specific heat 等容比热
        /// </summary>
        cv,

        /// <summary>
        /// speed of sound  声速
        /// </summary>
        w,
        drhodp,

        /// <summary>
        /// dynamic viscosity, μ 动力粘度
        /// </summary>
        mu,

        /// <summary>
        /// thermal conductivity 热导率.
        /// </summary>
        tc
    }

    /// <summary>
    /// Saturated Liquid/Vapor state determination
    /// </summary>
    public enum SatState
    {
        NONE, LIQUID, VAPOR
    }
}
