<?xml version="1.0" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:catalogue="urn:catalogue">

  <xsl:template match="/">
    <html xsl:version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <head>
        <title>Audio Catalogue</title>
      <style>
        table {
        border-radius: 10px;
        }

        table, td {
        padding: 5px;
        border: 1px solid grey;

        }

        th {
        background-color: lightblue;
        border-radius: 3px;
        }
      </style>
      </head>
      <body style="font-family:Arial;font-size:13px;color: grey;background-color:#EEEEEE">
        <h1>Audio Catalogie</h1>
        <table cellspacing="1" style="background-color:#F5F5DC;color:#2F4F4F;padding:4px">
          <tr>
            <th>Album Name</th>
            <th>Artist</th>
            <th>Year</th>
            <th>Producer</th>
            <th>Price</th>
            <th>Songs</th>
          </tr>
          <xsl:for-each select="/catalogue/album">
            <tr>
              <td>
                <xsl:value-of select="name" />
              </td>
              <td>
                <xsl:value-of select="artist" />
              </td>
              <td>
                <xsl:value-of select="year" />
              </td>
              <td>
                <xsl:value-of select="producer" />
              </td>
              <td>
                <xsl:value-of select="price" />
              </td>
              <td>
                <table cellspacing="1" style="background-color:#F5F5DC;color:#2F4F4F;padding:4px">
                  <tr bgcolor="#EEEEEE">
                    <th>Song Title</th>
                    <th>Duration</th>
                  </tr>
                  <xsl:for-each select="songs/song">
                    <tr>
                      <td>
                        <xsl:value-of select="title" />
                      </td>
                      <td>
                        <xsl:value-of select="duration" />
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
