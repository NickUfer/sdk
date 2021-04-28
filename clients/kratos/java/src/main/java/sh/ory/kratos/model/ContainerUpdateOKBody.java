/*
 * Ory Kratos API
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.0.0-alpha.38
 * Contact: hi@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.kratos.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * ContainerUpdateOKBody OK response to ContainerUpdate operation
 */
@ApiModel(description = "ContainerUpdateOKBody OK response to ContainerUpdate operation")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-04-28T23:15:40.169335+02:00[Europe/Berlin]")
public class ContainerUpdateOKBody {
  public static final String SERIALIZED_NAME_WARNINGS = "Warnings";
  @SerializedName(SERIALIZED_NAME_WARNINGS)
  private List<String> warnings = new ArrayList<>();


  public ContainerUpdateOKBody warnings(List<String> warnings) {
    
    this.warnings = warnings;
    return this;
  }

  public ContainerUpdateOKBody addWarningsItem(String warningsItem) {
    this.warnings.add(warningsItem);
    return this;
  }

   /**
   * warnings
   * @return warnings
  **/
  @ApiModelProperty(required = true, value = "warnings")

  public List<String> getWarnings() {
    return warnings;
  }


  public void setWarnings(List<String> warnings) {
    this.warnings = warnings;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ContainerUpdateOKBody containerUpdateOKBody = (ContainerUpdateOKBody) o;
    return Objects.equals(this.warnings, containerUpdateOKBody.warnings);
  }

  @Override
  public int hashCode() {
    return Objects.hash(warnings);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContainerUpdateOKBody {\n");
    sb.append("    warnings: ").append(toIndentedString(warnings)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

