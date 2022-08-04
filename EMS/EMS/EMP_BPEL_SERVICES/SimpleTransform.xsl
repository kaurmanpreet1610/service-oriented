<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
      xmlns:tns="http://Employeemanagement.Milestone3.SC13Project/"
      xmlns:xs="http://www.w3.org/2001/XMLSchema"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"       
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
	  <tns:InputDate>
		  <tns:date xsi:type="xs:int">
		     <xsl:value-of select="substring(//tns:departuredate, 9,2)"/>
		  </tns:date>
		  <tns:month xsi:type="xs:int">
		     <xsl:value-of select="substring(//tns:departuredate, 6,2)"/>
		  </tns:month>
		  <tns:year xsi:type="xs:int">
		     <xsl:value-of select="substring(//tns:departuredate, 1,4)"/>
		  </tns:year>
		   <tns:year xsi:type="xs:int">
		     <xsl:value-of select="substring(//tns:returndate, 4,9)"/>
		  </tns:year> 
          </tns:InputDate>		
	</xsl:template>
</xsl:stylesheet>
