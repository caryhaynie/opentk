﻿#region --- OpenTK.OpenAL License ---
/* EfxFunctions.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.OpenAL
{
    public partial class Efx
    {
        #region Effect object delegates

        // typedef void (__cdecl *LPALGENEFFECTS)( ALsizei n, ALuint* effects );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenEffects(int n, [Out] uint* effects);

        // typedef void (__cdecl *LPALDELETEEFFECTS)( ALsizei n, ALuint* effects );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alDeleteEffects(int n, [In] uint* effects);

        // typedef ALboolean (__cdecl *LPALISEFFECT)( ALuint eid );
        [CLSCompliant(false)]
        private delegate bool Delegate_alIsEffect(uint eid);

        // typedef void (__cdecl *LPALEFFECTI)( ALuint eid, ALenum param, ALint value); 
        [CLSCompliant(false)]
        private delegate void Delegate_alEffecti(uint eid, Enums.EfxEffecti param, int value);

        // typedef void (__cdecl *LPALEFFECTF)( ALuint eid, ALenum param, ALfloat value);
        [CLSCompliant(false)]
        private delegate void Delegate_alEffectf(uint eid, Enums.EfxEffectf param, float value);

        // typedef void (__cdecl *LPALGETEFFECTI)( ALuint eid, ALenum pname, ALint* value );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetEffecti(uint eid, Enums.EfxEffecti pname, [Out] int* value);

        // typedef void (__cdecl *LPALGETEFFECTF)( ALuint eid, ALenum pname, ALfloat* value );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetEffectf(uint eid, Enums.EfxEffectf pname, [Out]float* value);

        // Not used:
        // typedef void (__cdecl *LPALEFFECTIV)( ALuint eid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALEFFECTFV)( ALuint eid, ALenum param, ALfloat* values ); 
        // typedef void (__cdecl *LPALGETEFFECTIV)( ALuint eid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETEFFECTFV)( ALuint eid, ALenum pname, ALfloat* values );

        #endregion Effect object delegates

        #region Filter object delegates

        // typedef void (__cdecl *LPALGENFILTERS)( ALsizei n, ALuint* filters ); 
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenFilters(int n, [Out] uint* filters);

        // typedef void (__cdecl *LPALDELETEFILTERS)( ALsizei n, ALuint* filters );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alDeleteFilters(int n, [In] uint* filters);

        // typedef ALboolean (__cdecl *LPALISFILTER)( ALuint fid );
        [CLSCompliant(false)]
        private delegate bool Delegate_alIsFilter(uint fid);

        // typedef void (__cdecl *LPALFILTERI)( ALuint fid, ALenum param, ALint value );
        [CLSCompliant(false)]
        private delegate void Delegate_alFilteri(uint fid, Enums.EfxFilteri param, int value);

        // typedef void (__cdecl *LPALFILTERF)( ALuint fid, ALenum param, ALfloat value); 
        [CLSCompliant(false)]
        private delegate void Delegate_alFilterf(uint fid, Enums.EfxFilterf param, float value);

        // typedef void (__cdecl *LPALGETFILTERI)( ALuint fid, ALenum pname, ALint* value );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetFilteri(uint fid, Enums.EfxFilteri pname, [Out] int* value);

        // typedef void (__cdecl *LPALGETFILTERF)( ALuint fid, ALenum pname, ALfloat* value );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetFilterf(uint fid, Enums.EfxFilterf pname, [Out] float* value);

        // Not used:
        // typedef void (__cdecl *LPALFILTERIV)( ALuint fid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALFILTERFV)( ALuint fid, ALenum param, ALfloat* values ); 
        // typedef void (__cdecl *LPALGETFILTERIV)( ALuint fid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETFILTERFV)( ALuint fid, ALenum pname, ALfloat* values );

        #endregion Filter object delegates

        #region Auxiliary Slot object delegates

        // typedef void (__cdecl *LPALGENAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenAuxiliaryEffectSlots(int n, [Out] uint* slots);

        // typedef void (__cdecl *LPALDELETEAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alDeleteAuxiliaryEffectSlots(int n, [In] uint* slots);

        // typedef ALboolean (__cdecl *LPALISAUXILIARYEFFECTSLOT)( ALuint slot ); 
        [CLSCompliant(false)]
        private delegate bool Delegate_alIsAuxiliaryEffectSlot(uint slot);

        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum param, ALint value ); 
        [CLSCompliant(false)]
        private delegate void Delegate_alAuxiliaryEffectSloti(uint asid, Enums.EfxAuxiliaryi param, int value);

        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum param, ALfloat value ); 
        [CLSCompliant(false)]
        private delegate void Delegate_alAuxiliaryEffectSlotf(uint asid, Enums.EfxAuxiliaryf param, float value);

        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum pname, ALint* value );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetAuxiliaryEffectSloti(uint asid, Enums.EfxAuxiliaryi pname, [Out] int* value);

        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum pname, ALfloat* value );
        [CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetAuxiliaryEffectSlotf(uint asid, Enums.EfxAuxiliaryf pname, [Out] float* value);

        // Not used:
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum param, ALfloat* values ); 
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum pname, ALfloat* values );

        #endregion Auxiliary Slot object delegates

        #region Effect object functions

        [CLSCompliant(false)]
        private Delegate_alGenEffects Imported_alGenEffects;
        [CLSCompliant(false)]
        private Delegate_alDeleteEffects Imported_alDeleteEffects;
        [CLSCompliant(false)]
        private Delegate_alIsEffect Imported_alIsEffect;
        [CLSCompliant(false)]
        private Delegate_alEffecti Imported_alEffecti;
        [CLSCompliant(false)]
        private Delegate_alEffectf Imported_alEffectf;
        [CLSCompliant(false)]
        private Delegate_alGetEffecti Imported_alGetEffecti;
        [CLSCompliant(false)]
        private Delegate_alGetEffectf Imported_alGetEffectf;

        #endregion Effect object functions

        #region Filter object functions

        [CLSCompliant(false)]
        private Delegate_alGenFilters Imported_alGenFilters;
        [CLSCompliant(false)]
        private Delegate_alDeleteFilters Imported_alDeleteFilters;
        [CLSCompliant(false)]
        private Delegate_alIsFilter Imported_alIsFilter;
        [CLSCompliant(false)]
        private Delegate_alFilteri Imported_alFilteri;
        [CLSCompliant(false)]
        private Delegate_alFilterf Imported_alFilterf;
        [CLSCompliant(false)]
        private Delegate_alGetFilteri Imported_alGetFilteri;
        [CLSCompliant(false)]
        private Delegate_alGetFilterf Imported_alGetFilterf;

        #endregion Filter object functions

        #region Auxiliary Effect Slot functions

        [CLSCompliant(false)]
        private Delegate_alGenAuxiliaryEffectSlots Imported_alGenAuxiliaryEffectSlots;
        [CLSCompliant(false)]
        private Delegate_alDeleteAuxiliaryEffectSlots Imported_alDeleteAuxiliaryEffectSlots;
        [CLSCompliant(false)]
        private Delegate_alIsAuxiliaryEffectSlot Imported_alIsAuxiliaryEffectSlot;
        [CLSCompliant(false)]
        private Delegate_alAuxiliaryEffectSloti Imported_alAuxiliaryEffectSloti;
        [CLSCompliant(false)]
        private Delegate_alAuxiliaryEffectSlotf Imported_alAuxiliaryEffectSlotf;
        [CLSCompliant(false)]
        private Delegate_alGetAuxiliaryEffectSloti Imported_alGetAuxiliaryEffectSloti;
        [CLSCompliant(false)]
        private Delegate_alGetAuxiliaryEffectSlotf Imported_alGetAuxiliaryEffectSlotf;

        #endregion Auxiliary Effect Slot functions


        #region Constructor / Extension Loading

        private bool _valid;

        /// <summary>Returns True if the EFX Extension has been found and could be initialized.</summary>
        public bool IsInitialized
        { get { return _valid; } }

        public Efx()
        {
            _valid = false;

            if (Alc.IsExtensionPresent( Alc.GetContextsDevice( Alc.GetCurrentContext()) , "ALC_EXT_EFX") == false)
            {
                Console.WriteLine("Extension unknown.");
                return;
            }

            try
            {
                Imported_alGenEffects = (Delegate_alGenEffects)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenEffects"), typeof(Delegate_alGenEffects));
                Imported_alDeleteEffects = (Delegate_alDeleteEffects)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteEffects"), typeof(Delegate_alDeleteEffects));
                Imported_alIsEffect = (Delegate_alIsEffect)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsEffect"), typeof(Delegate_alIsEffect));
                Imported_alEffecti = (Delegate_alEffecti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffecti"), typeof(Delegate_alEffecti));
                Imported_alEffectf = (Delegate_alEffectf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffectf"), typeof(Delegate_alEffectf));
                Imported_alGetEffecti = (Delegate_alGetEffecti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffecti"), typeof(Delegate_alGetEffecti));
                Imported_alGetEffectf = (Delegate_alGetEffectf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffectf"), typeof(Delegate_alGetEffectf));
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to marshal Effect functions. " + e.ToString());
                return;
            }

            try
            {
                Imported_alGenFilters = (Delegate_alGenFilters)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenFilters"), typeof(Delegate_alGenFilters));
                Imported_alDeleteFilters = (Delegate_alDeleteFilters)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteFilters"), typeof(Delegate_alDeleteFilters));
                Imported_alIsFilter = (Delegate_alIsFilter)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsFilter"), typeof(Delegate_alIsFilter));
                Imported_alFilteri = (Delegate_alFilteri)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilteri"), typeof(Delegate_alFilteri));
                Imported_alFilterf = (Delegate_alFilterf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilterf"), typeof(Delegate_alFilterf));
                Imported_alGetFilteri = (Delegate_alGetFilteri)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilteri"), typeof(Delegate_alGetFilteri));
                Imported_alGetFilterf = (Delegate_alGetFilterf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilterf"), typeof(Delegate_alGetFilterf));
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to marshal Filter functions. " + e.ToString());
                return;
            }

            try
            {
                Imported_alGenFilters = (Delegate_alGenFilters)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenFilters"), typeof(Delegate_alGenFilters));
                Imported_alDeleteFilters = (Delegate_alDeleteFilters)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilters"), typeof(Delegate_alDeleteFilters));
                Imported_alIsFilter = (Delegate_alIsFilter)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsFilter"), typeof(Delegate_alIsFilter));
                Imported_alFilteri = (Delegate_alFilteri)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilteri"), typeof(Delegate_alFilteri));
                Imported_alFilterf = (Delegate_alFilterf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilterf"), typeof(Delegate_alFilterf));
                Imported_alGetFilteri = (Delegate_alGetFilteri)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilteri"), typeof(Delegate_alGetFilteri));
                Imported_alGetFilterf = (Delegate_alGetFilterf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilterf"), typeof(Delegate_alGetFilterf));
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to marshal Filter functions. " + e.ToString());
                return;
            }

            try
            {
                Imported_alGenAuxiliaryEffectSlots = (Delegate_alGenAuxiliaryEffectSlots)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenAuxiliaryEffectSlots"), typeof(Delegate_alGenAuxiliaryEffectSlots));
                Imported_alDeleteAuxiliaryEffectSlots = (Delegate_alDeleteAuxiliaryEffectSlots)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteAuxiliaryEffectSlots"), typeof(Delegate_alDeleteAuxiliaryEffectSlots));
                Imported_alIsAuxiliaryEffectSlot = (Delegate_alIsAuxiliaryEffectSlot)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsAuxiliaryEffectSlot"), typeof(Delegate_alIsAuxiliaryEffectSlot));
                Imported_alAuxiliaryEffectSloti = (Delegate_alAuxiliaryEffectSloti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alAuxiliaryEffectSloti"), typeof(Delegate_alAuxiliaryEffectSloti));
                Imported_alAuxiliaryEffectSlotf = (Delegate_alAuxiliaryEffectSlotf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alAuxiliaryEffectSlotf"), typeof(Delegate_alAuxiliaryEffectSlotf));
                Imported_alGetAuxiliaryEffectSloti = (Delegate_alGetAuxiliaryEffectSloti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetAuxiliaryEffectSloti"), typeof(Delegate_alGetAuxiliaryEffectSloti));
                Imported_alGetAuxiliaryEffectSlotf = (Delegate_alGetAuxiliaryEffectSlotf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetAuxiliaryEffectSlotf"), typeof(Delegate_alGetAuxiliaryEffectSlotf));
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to marshal AuxiliaryEffectSlot functions. " + e.ToString());
                return;
            }

            // not early return, everything went fine.
            _valid = true;
        }

        #endregion Constructor / Extension Loading
    }
}
