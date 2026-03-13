dnl Process this file with autoconf to produce a configure script.
AC_PREREQ([2.54])
AC_INIT([DiffieHellman], [0.1])
AM_INIT_AUTOMAKE([foreign])
AM_MAINTAINER_MODE
AC_PROG_INSTALL


dnl Version information
MONO_REQUIRED_VERSION=2.6.0


dnl Package information
ASSEMBLY_RELEASE=1.0.0
ASSEMBLY_BUILD=0
ASSEMBLY_TITLE="DiffieHellman"
ASSEMBLY_SHORT="diffiehellman"
ASSEMBLY_DESCRIPTION="Diffie-Hellman implementation for .NET"
ASSEMBLY_CONFIGURATION=""
ASSEMBLY_COMPANY="mentalis.org"
ASSEMBLY_PRODUCT="DiffieHellman"
ASSEMBLY_COPYRIGHT="Copyright © 2002-2003, The KPD-Team"
ASSEMBLY_TRADEMARK=""
ASSEMBLY_CULTURE=""
ASSEMBLY_VERSION="$ASSEMBLY_RELEASE.$ASSEMBLY_BUILD"
ASSEMBLY_KEYFILE="../../diffiehellman.snk"
ASSEMBLY_KEYNAME=""
ASSEMBLY_PACKAGE="$ASSEMBLY_PRODUCT"

ASSEMBLY_LONG_DESCRIPTION="The cryptography classes of the .NET framework lack one crucial class: \
an implementation of the Diffie-Hellman key agreement algorithm. To fill this gap, we created a \
completely managed Diffie-Hellman implementation, based on mono::'s BigInteger class."

ASSEMBLY_SUMMARY="A .NET implementation of Diffie-Hellman cryptography algorithm"

AC_SUBST(ASSEMBLY_RELEASE)
AC_SUBST(ASSEMBLY_BUILD)
AC_SUBST(ASSEMBLY_TITLE)
AC_SUBST(ASSEMBLY_SHORT)
AC_SUBST(ASSEMBLY_DESCRIPTION)
AC_SUBST(ASSEMBLY_CONFIGURATION)
AC_SUBST(ASSEMBLY_COMPANY)
AC_SUBST(ASSEMBLY_PRODUCT)
AC_SUBST(ASSEMBLY_COPYRIGHT)
AC_SUBST(ASSEMBLY_TRADEMARK)
AC_SUBST(ASSEMBLY_CULTURE)
AC_SUBST(ASSEMBLY_VERSION)
AC_SUBST(ASSEMBLY_KEYFILE)
AC_SUBST(ASSEMBLY_KEYNAME)
AC_SUBST(ASSEMBLY_PACKAGE)
AC_SUBST(ASSEMBLY_LONG_DESCRIPTION)
AC_SUBST(ASSEMBLY_SUMMARY)


dnl pkg-config
AC_PATH_PROG(PKG_CONFIG, pkg-config, no)
if test "x$PKG_CONFIG" = "xno"; then
        AC_MSG_ERROR([You need to install pkg-config])
fi

SHAMROCK_EXPAND_LIBDIR
SHAMROCK_EXPAND_BINDIR
SHAMROCK_EXPAND_DATADIR


dnl Mono existance check
PKG_CHECK_MODULES(MONO, mono >= $MONO_REQUIRED_VERSION, has_mono="yes", has_mono="no")
if test "x$has_mono" = "xno" ; then
	AC_MSG_ERROR([Mono at version at least $MONO_REQUIRED_VERSION not found])
fi


dnl C# compiler checks
CS="C#"
if test "x$CSC" = "xno" ; then
    AC_MSG_ERROR([No $CS compiler found])
fi

AC_SUBST(CSC)


dnl 2.0 Compiler check
AC_PATH_PROG(GMCS, gmcs, no)
if test "x$GMCS" = "xno"; then
        AC_MSG_ERROR([gmcs Not found])
fi


dnl Debug enable check
AC_ARG_ENABLE(debug,
	AC_HELP_STRING([--enable-debug],
		[Use 'DEBUG' Configuration [default=NO]]),
		enable_debug=yes, enable_debug=no)
AM_CONDITIONAL(ENABLE_DEBUG, test x$enable_debug = xyes)
if test "x$enable_debug" = "xyes" ; then
	CONFIG_REQUESTED="yes"
fi
AC_ARG_ENABLE(release,
	AC_HELP_STRING([--enable-release],
		[Use 'RELEASE' Configuration [default=YES]]),
		enable_release=yes, enable_release=no)
AM_CONDITIONAL(ENABLE_RELEASE, test x$enable_release = xyes)
if test "x$enable_release" = "xyes" ; then
	CONFIG_REQUESTED="yes"
fi
if test -z "$CONFIG_REQUESTED" ; then
	AM_CONDITIONAL(ENABLE_RELEASE, true)
	enable_release=yes
fi


dnl Global Assembly Cache util check
AC_PATH_PROG(GACUTIL, gacutil, no)
if test "x$GACUTIL" = "xno" ; then
        AC_MSG_ERROR([No gacutil tool found])
fi


dnl package checks, common for all configs


dnl package checks, per config


dnl Configuration files
AC_CONFIG_FILES([
src/AssemblyInfo.cs
diffiehellman.pc
Makefile
diffiehellman.spec

])


dnl Output user info
AC_OUTPUT

echo ""
echo "Configuration summary"
echo "---------------------"
echo ""
echo "   * Installation prefix: $prefix"
echo "   * compiler: $CSC"
echo ""

