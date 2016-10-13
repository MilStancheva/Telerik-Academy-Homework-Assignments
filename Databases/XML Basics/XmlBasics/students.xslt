<?xml version="1.0" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:students="urn:students">

        <xsl:template match="/">
            <html>
            <body>
                <h1>Students</h1>
                <table bgcolor="#E0E0E0" cellspacing="1">
                    <tr bgcolor="#EEEEEE">
                        <th>First Name</th>
                        <th>Second Name</th>
                        <th>Gender</th>
                        <th>Birthday</th>
                        <th>Phone</th>
                        <th>Email</th>
                        <th>Specialty</th>
                        <th>Faculty Number</th>
                        <th>Teachers Endorsement</th>
                        <th>Exams</th>
                    </tr>
                    <xsl:for-each select="/students/student">
                        <tr bgcolor="white">
                            <td>
                                <xsl:value-of select="firstName" />
                            </td>
                            <td>
                                <xsl:value-of select="lastName" />
                            </td>
                            <td>
                                <xsl:value-of select="gender" />
                            </td>
                            <td>
                                <xsl:value-of select="birthDate" />
                            </td>
                            <td>
                                <xsl:value-of select="phone" />
                            </td>
                            <td>
                                <xsl:value-of select="email" />
                            </td>
                            <td>
                                <xsl:value-of select="specialty" />
                            </td>
                            <td>
                                <xsl:value-of select="facultyNumber" />
                            </td>
                            <td>
                                <xsl:value-of select="teachersEndorsements" />
                            </td>
                            <td>
                                <table cellspacing="1">
                                    <tr bgcolor="#EEEEEE">
                                        <th>Course Name</th>
                                        <th>Tutor</th>
                                        <th>Date</th>
                                        <th>Exam Score</th>
                                        <th>Score</th>
                                    </tr>
                                    <xsl:for-each select="exams/exam">
                                        <tr>
                                            <td>
                                                <xsl:value-of select="examName" />
                                            </td>
                                            <td>
                                                <xsl:value-of select="tutor" />
                                            </td>
                                            <td>
                                                <xsl:value-of select="date" />
                                            </td>
                                            <td>
                                                <xsl:value-of select="examScore" />
                                            </td>
                                            <td>
                                                <xsl:value-of select="score" />
                                            </td>
                                        </tr>
                                    </xsl:for-each>
                                </table>
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
