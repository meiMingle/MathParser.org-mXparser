/*
 * @(#)Miscellaneous.cs        5.0.0    2022-04-10
 *
 * Copyright 2010 - 2022 MARIUSZ GROMADA. All rights reserved.
 *
 * PRODUCT: MathParser.org-mXparser
 * LICENSE: DUAL LICENSE
 *
 * SOFTWARE means source code and/or binary form and/or documentation.
 *
 * BY INSTALLING, COPYING, OR OTHERWISE USING THE SOFTWARE, YOU AGREE TO BE
 * BOUND BY ALL OF THE TERMS AND CONDITIONS OF THE DUAL LICENSE AGREEMENT.
 *
 * MARIUSZ GROMADA provides MathParser.org-mXparser SOFTWARE under the
 * DUAL LICENSE model designed to meet the needs of both Non-Commercial Use
 * as well as Commercial Use.
 *
 * NON-COMMERCIAL USE means any use or activity where a fee is not charged
 * and the purpose is not the sale of a good or service, and the use or
 * activity is not intended to produce a profit. NON-COMMERCIAL USE examples:
 *
 * 1. Free Open-Source Software ("FOSS").
 * 2. Non-commercial use in research, scholarly and education.
 *
 * COMMERCIAL USE means any use or activity where a fee is charged or the
 * purpose is the sale of a good or service, or the use or activity is
 * intended to produce a profit. COMMERCIAL USE examples:
 *
 * 1. OEMs (Original Equipment Manufacturers).
 * 2. ISVs (Independent Software Vendors).
 * 3. VARs (Value Added Resellers).
 * 4. Other distributors that combine and distribute commercially licensed
 *    software.
 *
 * IN CASE YOU WANT TO USE THE SOFTWARE COMMERCIALLY, YOU MUST PURCHASE
 * THE APPROPRIATE LICENSE FROM "INFIMA IWONA GLOWACKA-GROMADA", ONLINE
 * STORE ADDRESS: HTTPS://PAYHIP.COM/INFIMA
 *
 * NON-COMMERCIAL LICENSE
 *
 * Redistribution and use of the PRODUCT in source and/or binary forms, with
 * or without modification, are permitted provided that the following
 * conditions are met:
 *
 * 1. Redistributions of source code must retain unmodified content of the
 *    entire MathParser.org-mXparser DUAL LICENSE, including definition of
 *    NON-COMMERCIAL USE, definition of COMMERCIAL USE, NON-COMMERCIAL
 *    LICENSE conditions, COMMERCIAL LICENSE conditions, and the following
 *    DISCLAIMER.
 * 2. Redistributions in binary form must reproduce the entire content of
 *    MathParser.org-mXparser DUAL LICENSE in the documentation and/or other
 *    materials provided with the distribution, including definition of
 *    NON-COMMERCIAL USE, definition of COMMERCIAL USE, NON-COMMERCIAL
 *    LICENSE conditions, COMMERCIAL LICENSE conditions, and the following
 *    DISCLAIMER.
 *
 * COMMERCIAL LICENSE
 *
 *  1. Before purchasing a commercial license, MARIUSZ GROMADA allows you to
 *     download, install and use up to three copies of the PRODUCT to perform
 *     integration tests, confirm the quality of the PRODUCT and its
 *     suitability. The testing period should be limited to one month. Tests
 *     should take place via test environments. The purpose of the tests must
 *     not be to generate profit.
 *  2. Provided that you purchased a license from "INFIMA IWONA GLOWACKA-GROMADA"
 *     (online store address: https://payhip.com/INFIMA), you comply with all
 *     below terms and conditions, and you have acknowledged and understood the
 *     following DISCLAIMER, MARIUSZ GROMADA grants you a nonexclusive license
 *     including the following rights:
 *  3. In case you purchased a "Single License" You can install and use the
 *     PRODUCT from one workstation.
 *  4. Additional copies of the PRODUCT can be installed and used from more
 *     than one workstation; however, this number is limited to the number of
 *     copies purchased as per order.
 *  5. In case you purchased a "Site License", the PRODUCT can be installed
 *     and used from all workstations located at your premises.
 *  6. You may incorporate the unmodified PRODUCT into your own products and
 *     software.
 *  7. If you purchased a license with the "Source Code" option, you may modify
 *     the PRODUCT's source code and incorporate the modified source code into
 *     your own products and / or software.
 *  8. You may distribute your product and / or software with the incorporated
 *     PRODUCT royalty-free.
 *  9. You may make copies of the PRODUCT for backup and archival purposes.
 * 10. MARIUSZ GROMADA reserves all rights not expressly granted to you in
 *     this agreement.
 *
 * CONTACT
 * - e-mail: info@mathparser.org
 * - website: https://mathparser.org
 * - source code: https://github.com/mariuszgromada/MathParser.org-mXparser
 * - online store: https://payhip.com/INFIMA
 *
 * DISCLAIMER
 *
 * THIS SOFTWARE IS PROVIDED BY MARIUSZ GROMADA "AS IS" AND ANY EXPRESS OR
 * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL MATHPARSER.ORG MARIUSZ GROMADA OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE
 * USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * THE VIEWS AND CONCLUSIONS CONTAINED IN THE SOFTWARE AND DOCUMENTATION ARE
 * THOSE OF THE AUTHORS AND SHOULD NOT BE INTERPRETED AS REPRESENTING OFFICIAL
 * POLICIES, EITHER EXPRESSED OR IMPLIED, OF MARIUSZ GROMADA.
 */

using System;
using org.mariuszgromada.math.mxparser.mathcollection;

namespace org.mariuszgromada.math.mxparser.test {

    /**
     * Common tools for unit tests
     */
    internal class TestCommonTools {
        internal static void consolePrintOptionsMxparser(String prefix) {
            mXparser.consolePrintSettings(prefix);
        }

        internal static void consolePrintOptionsExpression(Expression testExp) {
            mXparser.consolePrintln("------------ OPTIONS AFTER ------------");
            mXparser.consolePrintln("getImpliedMultiplicationMode = " + testExp.checkIfImpliedMultiplicationMode());
            mXparser.consolePrintln("getCanonicalExpressionString = " + testExp.getCanonicalExpressionString());
            mXparser.consolePrintSettings();
            mXparser.consolePrintln("getErrorMessage = " + testExp.getErrorMessage());
            mXparser.consolePrintln("checkLexSyntax = " + testExp.checkLexSyntax());
            mXparser.consolePrintln("checkSyntax = " + testExp.checkSyntax());
            mXparser.consolePrintln("getCopyOfInitialTokens = ");
            mXparser.consolePrintTokens(testExp.getCopyOfInitialTokens());
        }

        internal static void consolePrintTestStart(int testId, String testStr, String testType) {
            mXparser.consolePrintln();
            mXparser.consolePrintln("[" + testType +"/" + testId + "] ------------ TEST INIT: " + testStr);
            mXparser.consolePrintln("-- Options before");
            consolePrintOptionsMxparser("---- ");
            mXparser.consolePrint("[" + testType +"/" + testId + "] Starting test: " + testStr + " ...... ");
        }

        internal static void consolePrintTestExprStart(int testId, String testStr) {
            consolePrintTestStart(testId, testStr, "Expr");
        }

        internal static void consolePrintTestExprEnd(double calculatedValue, double expectedValue, bool testResult, Expression testExp) {
            mXparser.consolePrint("Test finished, calculated = " + calculatedValue + " expected = " + expectedValue + " diff = " + MathFunctions.abs(calculatedValue - expectedValue) + " --> result ");
            if (testResult) {
                mXparser.consolePrintln("OK, time = " + testExp.getComputingTime());
            } else {
                mXparser.consolePrintln("ERROR, time = " + testExp.getComputingTime());
                consolePrintOptionsExpression(testExp);
            }
        }

        internal static void consolePrintTestSynEnd(bool receivedSyntax, bool expectedSyntax, bool testResult, Expression testExp) {
            mXparser.consolePrint("Test finished, received = " + receivedSyntax + " expected = " + expectedSyntax + " --> result ");
            if (testResult) {
                mXparser.consolePrintln("OK, time = " + testExp.getComputingTime());
            } else {
                mXparser.consolePrintln("ERROR, time = " + testExp.getComputingTime());
                consolePrintOptionsExpression(testExp);
            }
        }


        internal static void consolePrintTestApiEnd(bool testResult) {
            mXparser.consolePrint("Test finished, result = " + testResult  + " --> result ");
            if (testResult) {
                mXparser.consolePrintln("OK");
            } else {
                mXparser.consolePrintln("ERROR");
            }
        }


        internal static void consolePrintTestSynStart(int testId, String testStr) {
            consolePrintTestStart(testId, testStr, "Syn");
        }

        internal static void consolePrintTestApiStart(int testId, String testDescr) {
            consolePrintTestStart(testId, testDescr, "API");
        }

        internal static void testExprSettingsInit() {
            mXparser.setEpsilonComparison();
            mXparser.setDefaultEpsilon();
            mXparser.enableUlpRounding();
            mXparser.enableImpliedMultiplicationMode();
            mXparser.enableUnicodeBuiltinKeyWordsMode();
        }
        internal static void testSynSettingsInit() {
            mXparser.setDefaultOptions();
        }
        internal static void testApiSettingsInit() {
            mXparser.setDefaultOptions();
        }
    }


	/**
	 * Example of implementation
	 * FunctionExtension interface
	 * @see FunctionExtension
	 */
	internal class FunExt : FunctionExtension {
		double x;
		double y;
		public FunExt() {
			x = Double.NaN;
			y = Double.NaN;
		}
		public FunExt(double x, double y) {
			this.x = x;
			this.y = y;
		}
		public int getParametersNumber() {
			return 2;
		}
		public void setParameterValue(int parameterIndex, double parameterValue) {
			if (parameterIndex == 0) x = parameterValue;
			if (parameterIndex == 1) y = parameterValue;
		}
		public String getParameterName(int parameterIndex) {
			if (parameterIndex == 0) return "x";
			if (parameterIndex == 1) return "y";
			return "";
		}
		public double calculate() {
			return x * y;
		}
		public FunctionExtension clone() {
			return new FunExt(x, y);
		}
	}
	/**
	 * Example of implementation
	 * FunctionExtensionVariadic interface
	 * @see FunctionExtensionVariadic
	 */
	internal class FunExtVar : FunctionExtensionVariadic {
		public double calculate(params double[] parameters) {
			if (parameters == null) return Double.NaN;
			if (parameters.Length == 0) return Double.NaN;
			double result = 0;
			foreach (double x in parameters)
				result+=x;
			return result;
		}
		public FunctionExtensionVariadic clone() {
			return new FunExtVar();
		}
	}
	/**
	 * Example of implementation
	 * ArgumentExtension interface
	 * @see ArgumentExtension
	 */
	internal class PiMultArgExt : ArgumentExtension {
		private int multiple = 0;
		public double getArgumentValue() {
			multiple++;
			return  MathConstants.PI * multiple;
		}
		public ArgumentExtension clone() {
			return new PiMultArgExt();
		}
	}

}