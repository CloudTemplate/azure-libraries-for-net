// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Dns.Fluent
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    internal partial class DnsZoneImpl
    {
        /// <summary>
        /// Gets entry point to manage record sets in this zone containing AAAA (IPv6 address) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.IAaaaRecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.AaaaRecordSets
        {
            get
            {
                return this.AaaaRecordSets() as Microsoft.Azure.Management.Dns.Fluent.IAaaaRecordSets;
            }
        }

        /// <summary>
        /// Gets the access type of this zone (Private or Public).
        /// </summary>
        Models.ZoneType Microsoft.Azure.Management.Dns.Fluent.IDnsZone.AccessType
        {
            get
            {
                return this.AccessType();
            }
        }

        /// <summary>
        /// Gets entry point to manage record sets in this zone containing A (IPv4 address) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.IARecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.ARecordSets
        {
            get
            {
                return this.ARecordSets() as Microsoft.Azure.Management.Dns.Fluent.IARecordSets;
            }
        }

        /// <summary>
        /// Gets entry point to manage record sets in this zone containing Caa (canonical name) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.ICaaRecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.CaaRecordSets
        {
            get
            {
                return this.CaaRecordSets() as Microsoft.Azure.Management.Dns.Fluent.ICaaRecordSets;
            }
        }

        /// <summary>
        /// Gets entry point to manage record sets in this zone containing CNAME (canonical name) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.ICNameRecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.CNameRecordSets
        {
            get
            {
                return this.CNameRecordSets() as Microsoft.Azure.Management.Dns.Fluent.ICNameRecordSets;
            }
        }

        /// <summary>
        /// Gets the etag associated with this zone.
        /// </summary>
        string Microsoft.Azure.Management.Dns.Fluent.IDnsZone.ETag
        {
            get
            {
                return this.ETag();
            }
        }

        /// <summary>
        /// Gets the maximum number of record sets that can be created in this zone.
        /// </summary>
        long Microsoft.Azure.Management.Dns.Fluent.IDnsZone.MaxNumberOfRecordSets
        {
            get
            {
                return this.MaxNumberOfRecordSets();
            }
        }

        /// <summary>
        /// Gets entry point to manage record sets in this zone containing MX (mail exchange) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.IMXRecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.MXRecordSets
        {
            get
            {
                return this.MXRecordSets() as Microsoft.Azure.Management.Dns.Fluent.IMXRecordSets;
            }
        }

        /// <summary>
        /// Gets name servers assigned for this zone.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<string> Microsoft.Azure.Management.Dns.Fluent.IDnsZone.NameServers
        {
            get
            {
                return this.NameServers() as System.Collections.Generic.IReadOnlyList<string>;
            }
        }

        /// <summary>
        /// Gets entry point to manage record sets in this zone containing NS (name server) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.INSRecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.NSRecordSets
        {
            get
            {
                return this.NSRecordSets() as Microsoft.Azure.Management.Dns.Fluent.INSRecordSets;
            }
        }

        /// <summary>
        /// Gets the current number of record sets in this zone.
        /// </summary>
        long Microsoft.Azure.Management.Dns.Fluent.IDnsZone.NumberOfRecordSets
        {
            get
            {
                return this.NumberOfRecordSets();
            }
        }

        /// <summary>
        /// Gets entry point to manage record sets in this zone containing PTR (pointer) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.IPtrRecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.PtrRecordSets
        {
            get
            {
                return this.PtrRecordSets() as Microsoft.Azure.Management.Dns.Fluent.IPtrRecordSets;
            }
        }

        /// <summary>
        /// Gets a list of references to virtual networks that register hostnames in this DNS zone for Private DNS zone.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<string> Microsoft.Azure.Management.Dns.Fluent.IDnsZone.RegistrationVirtualNetworkIds
        {
            get
            {
                return this.RegistrationVirtualNetworkIds() as System.Collections.Generic.IReadOnlyList<string>;
            }
        }

        /// <summary>
        /// Gets a list of references to virtual networks that resolve records in this DNS zone for Private DNS zone.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<string> Microsoft.Azure.Management.Dns.Fluent.IDnsZone.ResolutionVirtualNetworkIds
        {
            get
            {
                return this.ResolutionVirtualNetworkIds() as System.Collections.Generic.IReadOnlyList<string>;
            }
        }

        /// <summary>
        /// Gets entry point to manage record sets in this zone containing SRV (service) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.ISrvRecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.SrvRecordSets
        {
            get
            {
                return this.SrvRecordSets() as Microsoft.Azure.Management.Dns.Fluent.ISrvRecordSets;
            }
        }

        /// <summary>
        /// Gets entry point to manage record sets in this zone containing TXT (text) records.
        /// </summary>
        Microsoft.Azure.Management.Dns.Fluent.ITxtRecordSets Microsoft.Azure.Management.Dns.Fluent.IDnsZone.TxtRecordSets
        {
            get
            {
                return this.TxtRecordSets() as Microsoft.Azure.Management.Dns.Fluent.ITxtRecordSets;
            }
        }

        /// <summary>
        /// Specifies definition of an AAAA record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">Name of the AAAA record set.</param>
        /// <return>The stage representing configuration for the AAAA record set.</return>
        DnsRecordSet.UpdateDefinition.IAaaaRecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefineAaaaRecordSet(string name)
        {
            return this.DefineAaaaRecordSet(name) as DnsRecordSet.UpdateDefinition.IAaaaRecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of an AAAA record set.
        /// </summary>
        /// <param name="name">Name of the AAAA record set.</param>
        /// <return>The stage representing configuration for the AAAA record set.</return>
        DnsRecordSet.Definition.IAaaaRecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefineAaaaRecordSet(string name)
        {
            return this.DefineAaaaRecordSet(name) as DnsRecordSet.Definition.IAaaaRecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <summary>
        /// Specifies definition of an A record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">Name of the A record set.</param>
        /// <return>The stage representing configuration for the A record set.</return>
        DnsRecordSet.UpdateDefinition.IARecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefineARecordSet(string name)
        {
            return this.DefineARecordSet(name) as DnsRecordSet.UpdateDefinition.IARecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of an A record set.
        /// </summary>
        /// <param name="name">Name of the A record set.</param>
        /// <return>The stage representing configuration for the A record set.</return>
        DnsRecordSet.Definition.IARecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefineARecordSet(string name)
        {
            return this.DefineARecordSet(name) as DnsRecordSet.Definition.IARecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <summary>
        /// Specifies definition of a Caa record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">The name of the Caa record set.</param>
        /// <return>The stage representing configuration for the Caa record set.</return>
        DnsRecordSet.UpdateDefinition.ICaaRecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefineCaaRecordSet(string name)
        {
            return this.DefineCaaRecordSet(name) as DnsRecordSet.UpdateDefinition.ICaaRecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of a Caa record set.
        /// </summary>
        /// <param name="name">The name of the Caa record set.</param>
        /// <return>The stage representing configuration for the Caa record set.</return>
        DnsRecordSet.Definition.ICaaRecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefineCaaRecordSet(string name)
        {
            return this.DefineCaaRecordSet(name) as DnsRecordSet.Definition.ICaaRecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <summary>
        /// Specifies definition of a CNAME record set.
        /// </summary>
        /// <param name="name">Name of the CNAME record set.</param>
        /// <return>The next stage of DNS zone definition.</return>
        DnsRecordSet.UpdateDefinition.ICNameRecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefineCNameRecordSet(string name)
        {
            return this.DefineCNameRecordSet(name) as DnsRecordSet.UpdateDefinition.ICNameRecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of a CNAME record set.
        /// </summary>
        /// <param name="name">Name of the CNAME record set.</param>
        /// <return>The next stage of DNS zone definition.</return>
        DnsRecordSet.Definition.ICNameRecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefineCNameRecordSet(string name)
        {
            return this.DefineCNameRecordSet(name) as DnsRecordSet.Definition.ICNameRecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <summary>
        /// Specifies definition of a MX record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">Name of the MX record set.</param>
        /// <return>The stage representing configuration for the MX record set.</return>
        DnsRecordSet.UpdateDefinition.IMXRecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefineMXRecordSet(string name)
        {
            return this.DefineMXRecordSet(name) as DnsRecordSet.UpdateDefinition.IMXRecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of a MX record set.
        /// </summary>
        /// <param name="name">Name of the MX record set.</param>
        /// <return>The stage representing configuration for the MX record set.</return>
        DnsRecordSet.Definition.IMXRecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefineMXRecordSet(string name)
        {
            return this.DefineMXRecordSet(name) as DnsRecordSet.Definition.IMXRecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <summary>
        /// Specifies definition of an NS record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">Name of the NS record set.</param>
        /// <return>The stage representing configuration for the NS record set.</return>
        DnsRecordSet.UpdateDefinition.INSRecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefineNSRecordSet(string name)
        {
            return this.DefineNSRecordSet(name) as DnsRecordSet.UpdateDefinition.INSRecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of an NS record set.
        /// </summary>
        /// <param name="name">Name of the NS record set.</param>
        /// <return>The stage representing configuration for the NS record set.</return>
        DnsRecordSet.Definition.INSRecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefineNSRecordSet(string name)
        {
            return this.DefineNSRecordSet(name) as DnsRecordSet.Definition.INSRecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <summary>
        /// Specifies definition of a PTR record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">Name of the PTR record set.</param>
        /// <return>The stage representing configuration for the PTR record set.</return>
        DnsRecordSet.UpdateDefinition.IPtrRecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefinePtrRecordSet(string name)
        {
            return this.DefinePtrRecordSet(name) as DnsRecordSet.UpdateDefinition.IPtrRecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of a PTR record set.
        /// </summary>
        /// <param name="name">Name of the PTR record set.</param>
        /// <return>The stage representing configuration for the PTR record set.</return>
        DnsRecordSet.Definition.IPtrRecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefinePtrRecordSet(string name)
        {
            return this.DefinePtrRecordSet(name) as DnsRecordSet.Definition.IPtrRecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <summary>
        /// Specifies definition of a SRV record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">The name of the SRV record set.</param>
        /// <return>The stage representing configuration for the SRV record set.</return>
        DnsRecordSet.UpdateDefinition.ISrvRecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefineSrvRecordSet(string name)
        {
            return this.DefineSrvRecordSet(name) as DnsRecordSet.UpdateDefinition.ISrvRecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of a SRV record set.
        /// </summary>
        /// <param name="name">The name of the SRV record set.</param>
        /// <return>The stage representing configuration for the SRV record set.</return>
        DnsRecordSet.Definition.ISrvRecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefineSrvRecordSet(string name)
        {
            return this.DefineSrvRecordSet(name) as DnsRecordSet.Definition.ISrvRecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <summary>
        /// Specifies definition of a TXT record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">The name of the TXT record set.</param>
        /// <return>The stage representing configuration for the TXT record set.</return>
        DnsRecordSet.UpdateDefinition.ITxtRecordSetBlank<DnsZone.Update.IUpdate> DnsZone.Update.IWithRecordSet.DefineTxtRecordSet(string name)
        {
            return this.DefineTxtRecordSet(name) as DnsRecordSet.UpdateDefinition.ITxtRecordSetBlank<DnsZone.Update.IUpdate>;
        }

        /// <summary>
        /// Specifies definition of a TXT record set.
        /// </summary>
        /// <param name="name">The name of the TXT record set.</param>
        /// <return>The stage representing configuration for the TXT record set.</return>
        DnsRecordSet.Definition.ITxtRecordSetBlank<DnsZone.Definition.IWithCreate> DnsZone.Definition.IWithRecordSet.DefineTxtRecordSet(string name)
        {
            return this.DefineTxtRecordSet(name) as DnsRecordSet.Definition.ITxtRecordSetBlank<DnsZone.Definition.IWithCreate>;
        }

        /// <return>The record set containing SOA (start of authority) record associated with this DNS zone.</return>
        Microsoft.Azure.Management.Dns.Fluent.ISoaRecordSet Microsoft.Azure.Management.Dns.Fluent.IDnsZone.GetSoaRecordSet()
        {
            return this.GetSoaRecordSet() as Microsoft.Azure.Management.Dns.Fluent.ISoaRecordSet;
        }

        /// <return>The record sets in this zone.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet> Microsoft.Azure.Management.Dns.Fluent.IDnsZone.ListRecordSets()
        {
            return this.ListRecordSets() as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet>;
        }

        /// <summary>
        /// Lists all the record sets in this zone with the given suffix.
        /// </summary>
        /// <param name="recordSetNameSuffix">The record set name suffix.</param>
        /// <return>The record sets.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet> Microsoft.Azure.Management.Dns.Fluent.IDnsZone.ListRecordSets(string recordSetNameSuffix)
        {
            return this.ListRecordSets(recordSetNameSuffix) as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet>;
        }

        /// <summary>
        /// Lists all the record sets in this zone with each entries in each page
        /// limited to the given size.
        /// </summary>
        /// <param name="pageSize">The maximum number of record sets in a page.</param>
        /// <return>The record sets.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet> Microsoft.Azure.Management.Dns.Fluent.IDnsZone.ListRecordSets(int pageSize)
        {
            return this.ListRecordSets(pageSize) as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet>;
        }

        /// <summary>
        /// Lists all the record sets in this zone with the given suffix, also limits
        /// the number of entries per page to the given page size.
        /// </summary>
        /// <param name="recordSetNameSuffix">The record set name suffix.</param>
        /// <param name="pageSize">The maximum number of record sets in a page.</param>
        /// <return>The record sets.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet> Microsoft.Azure.Management.Dns.Fluent.IDnsZone.ListRecordSets(string recordSetNameSuffix, int pageSize)
        {
            return this.ListRecordSets(recordSetNameSuffix, pageSize) as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Dns.Fluent.IDnsRecordSet>;
        }

        /// <summary>
        /// Refreshes the resource to sync with Azure.
        /// </summary>
        /// <return>The Observable to refreshed resource.</return>
        async Task<Microsoft.Azure.Management.Dns.Fluent.IDnsZone> Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<Microsoft.Azure.Management.Dns.Fluent.IDnsZone>.RefreshAsync(CancellationToken cancellationToken)
        {
            return await this.RefreshAsync(cancellationToken) as Microsoft.Azure.Management.Dns.Fluent.IDnsZone;
        }

        /// <summary>
        /// Begins the description of an update of an existing AAAA record set in this DNS zone.
        /// </summary>
        /// <param name="name">Name of the AAAA record set.</param>
        /// <return>The stage representing configuration for the AAAA record set.</return>
        DnsRecordSet.UpdateAaaaRecordSet.IUpdateAaaaRecordSet DnsZone.Update.IWithRecordSet.UpdateAaaaRecordSet(string name)
        {
            return this.UpdateAaaaRecordSet(name) as DnsRecordSet.UpdateAaaaRecordSet.IUpdateAaaaRecordSet;
        }

        /// <summary>
        /// Begins the description of an update of an existing A record set in this DNS zone.
        /// </summary>
        /// <param name="name">Name of the A record set.</param>
        /// <return>The stage representing configuration for the A record set.</return>
        DnsRecordSet.UpdateARecordSet.IUpdateARecordSet DnsZone.Update.IWithRecordSet.UpdateARecordSet(string name)
        {
            return this.UpdateARecordSet(name) as DnsRecordSet.UpdateARecordSet.IUpdateARecordSet;
        }

        /// <summary>
        /// Begins the description of an update of an existing Caa record set in this DNS zone.
        /// </summary>
        /// <param name="name">The name of the Caa record set.</param>
        /// <return>The stage representing configuration for the Caa record set.</return>
        DnsRecordSet.UpdateCaaRecordSet.IUpdateCaaRecordSet DnsZone.Update.IWithRecordSet.UpdateCaaRecordSet(string name)
        {
            return this.UpdateCaaRecordSet(name) as DnsRecordSet.UpdateCaaRecordSet.IUpdateCaaRecordSet;
        }

        /// <summary>
        /// Specifies definition of a CNAME record set.
        /// </summary>
        /// <param name="name">Name of the CNAME record set.</param>
        /// <return>The stage representing configuration for the CNAME record set.</return>
        DnsRecordSet.UpdateCNameRecordSet.IUpdateCNameRecordSet DnsZone.Update.IWithRecordSet.UpdateCNameRecordSet(string name)
        {
            return this.UpdateCNameRecordSet(name) as DnsRecordSet.UpdateCNameRecordSet.IUpdateCNameRecordSet;
        }

        /// <summary>
        /// Begins the description of an update of an existing MX record set in this DNS zone.
        /// </summary>
        /// <param name="name">Name of the MX record set.</param>
        /// <return>The stage representing configuration for the MX record set.</return>
        DnsRecordSet.UpdateMXRecordSet.IUpdateMXRecordSet DnsZone.Update.IWithRecordSet.UpdateMXRecordSet(string name)
        {
            return this.UpdateMXRecordSet(name) as DnsRecordSet.UpdateMXRecordSet.IUpdateMXRecordSet;
        }

        /// <summary>
        /// Begins the description of an update of an existing NS record set in this DNS zone.
        /// </summary>
        /// <param name="name">Name of the NS record set.</param>
        /// <return>The stage representing configuration for the NS record set.</return>
        DnsRecordSet.UpdateNSRecordSet.IUpdateNSRecordSet DnsZone.Update.IWithRecordSet.UpdateNSRecordSet(string name)
        {
            return this.UpdateNSRecordSet(name) as DnsRecordSet.UpdateNSRecordSet.IUpdateNSRecordSet;
        }

        /// <summary>
        /// Begins the description of an update of an existing PTR record set in this DNS zone.
        /// </summary>
        /// <param name="name">Name of the PTR record set.</param>
        /// <return>The stage representing configuration for the PTR record set.</return>
        DnsRecordSet.UpdatePtrRecordSet.IUpdatePtrRecordSet DnsZone.Update.IWithRecordSet.UpdatePtrRecordSet(string name)
        {
            return this.UpdatePtrRecordSet(name) as DnsRecordSet.UpdatePtrRecordSet.IUpdatePtrRecordSet;
        }

        /// <summary>
        /// Begins the description of an update of the SOA record in this DNS zone.
        /// </summary>
        /// <return>The stage representing configuration for the TXT record set.</return>
        DnsRecordSet.UpdateSoaRecord.IUpdateSoaRecord DnsZone.Update.IWithRecordSet.UpdateSoaRecord()
        {
            return this.UpdateSoaRecord() as DnsRecordSet.UpdateSoaRecord.IUpdateSoaRecord;
        }

        /// <summary>
        /// Begins the description of an update of an existing SRV record set in this DNS zone.
        /// </summary>
        /// <param name="name">The name of the SRV record set.</param>
        /// <return>The stage representing configuration for the SRV record set.</return>
        DnsRecordSet.UpdateSrvRecordSet.IUpdateSrvRecordSet DnsZone.Update.IWithRecordSet.UpdateSrvRecordSet(string name)
        {
            return this.UpdateSrvRecordSet(name) as DnsRecordSet.UpdateSrvRecordSet.IUpdateSrvRecordSet;
        }

        /// <summary>
        /// Begins the description of an update of an existing TXT record set in this DNS zone.
        /// </summary>
        /// <param name="name">The name of the TXT record set.</param>
        /// <return>The stage representing configuration for the TXT record set.</return>
        DnsRecordSet.UpdateTxtRecordSet.IUpdateTxtRecordSet DnsZone.Update.IWithRecordSet.UpdateTxtRecordSet(string name)
        {
            return this.UpdateTxtRecordSet(name) as DnsRecordSet.UpdateTxtRecordSet.IUpdateTxtRecordSet;
        }

        /// <summary>
        /// Specifies definition of a CNAME record set to be attached to the DNS zone.
        /// </summary>
        /// <param name="name">Name of the CNAME record set.</param>
        /// <param name="alias">The CNAME record alias.</param>
        /// <return>The next stage of DNS zone definition.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithCNameRecordSet(string name, string alias)
        {
            return this.WithCNameRecordSet(name, alias) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Specifies definition of a CNAME record set.
        /// </summary>
        /// <param name="name">Name of the CNAME record set.</param>
        /// <param name="alias">The CNAME record alias.</param>
        /// <return>The next stage of DNS zone definition.</return>
        DnsZone.Definition.IWithCreate DnsZone.Definition.IWithRecordSet.WithCNameRecordSet(string name, string alias)
        {
            return this.WithCNameRecordSet(name, alias) as DnsZone.Definition.IWithCreate;
        }

        /// <summary>
        /// Specifies that If-Match header needs to set to the current eTag value associated
        /// with the DNS Zone.
        /// </summary>
        /// <return>The next stage of the update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithETagCheck.WithETagCheck()
        {
            return this.WithETagCheck() as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that if-Match header needs to set to the given eTag value.
        /// </summary>
        /// <param name="eTagValue">The eTag value.</param>
        /// <return>The next stage of the update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithETagCheck.WithETagCheck(string eTagValue)
        {
            return this.WithETagCheck(eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that If-None-Match header needs to set to  to prevent updating an existing DNS zone.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        DnsZone.Definition.IWithCreate DnsZone.Definition.IWithETagCheck.WithETagCheck()
        {
            return this.WithETagCheck() as DnsZone.Definition.IWithCreate;
        }

        /// <summary>
        /// Removes a AAAA record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the AAAA record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutAaaaRecordSet(string name)
        {
            return this.WithoutAaaaRecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a AAAA record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the AAAA record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutAaaaRecordSet(string name, string eTagValue)
        {
            return this.WithoutAaaaRecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a A record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the A record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutARecordSet(string name)
        {
            return this.WithoutARecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a A record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the A record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutARecordSet(string name, string eTagValue)
        {
            return this.WithoutARecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a Caa record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the Caa record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutCaaRecordSet(string name)
        {
            return this.WithoutCaaRecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a Caa record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the Caa record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutCaaRecordSet(string name, string eTagValue)
        {
            return this.WithoutCaaRecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a CNAME record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the CNAME record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutCNameRecordSet(string name)
        {
            return this.WithoutCNameRecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a CNAME record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the CNAME record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutCNameRecordSet(string name, string eTagValue)
        {
            return this.WithoutCNameRecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a MX record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the MX record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutMXRecordSet(string name)
        {
            return this.WithoutMXRecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a MX record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the MX record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutMXRecordSet(string name, string eTagValue)
        {
            return this.WithoutMXRecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a NS record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the NS record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutNSRecordSet(string name)
        {
            return this.WithoutNSRecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a NS record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the NS record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutNSRecordSet(string name, string eTagValue)
        {
            return this.WithoutNSRecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a PTR record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the PTR record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutPtrRecordSet(string name)
        {
            return this.WithoutPtrRecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a PTR record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the PTR record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutPtrRecordSet(string name, string eTagValue)
        {
            return this.WithoutPtrRecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a SRV record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the SRV record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutSrvRecordSet(string name)
        {
            return this.WithoutSrvRecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a SRV record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the SRV record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutSrvRecordSet(string name, string eTagValue)
        {
            return this.WithoutSrvRecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a TXT record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the TXT record set.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutTxtRecordSet(string name)
        {
            return this.WithoutTxtRecordSet(name) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Removes a TXT record set in the DNS zone.
        /// </summary>
        /// <param name="name">Name of the TXT record set.</param>
        /// <param name="eTagValue">The etag to use for concurrent protection.</param>
        /// <return>The next stage of DNS zone update.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithRecordSet.WithoutTxtRecordSet(string name, string eTagValue)
        {
            return this.WithoutTxtRecordSet(name, eTagValue) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Sets the type of this zone to Private.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithZoneType.WithPrivateAccess()
        {
            return this.WithPrivateAccess() as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Sets the type of this zone to Private.
        /// </summary>
        /// <param name="registrationVirtualNetworkIds">A list of references to virtual networks that register hostnames in this DNS zone.</param>
        /// <param name="resolutionVirtualNetworkIds">A list of references to virtual networks that resolve records in this DNS zone.</param>
        /// <return>The next stage of the definition.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithZoneType.WithPrivateAccess(IList<string> registrationVirtualNetworkIds, IList<string> resolutionVirtualNetworkIds)
        {
            return this.WithPrivateAccess(registrationVirtualNetworkIds, resolutionVirtualNetworkIds) as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Sets the type of this zone to Private.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        DnsZone.Definition.IWithCreate DnsZone.Definition.IWithZoneType.WithPrivateAccess()
        {
            return this.WithPrivateAccess() as DnsZone.Definition.IWithCreate;
        }

        /// <summary>
        /// Sets the type of this zone to Private.
        /// </summary>
        /// <param name="registrationVirtualNetworkIds">A list of references to virtual networks that register hostnames in this DNS zone.</param>
        /// <param name="resolutionVirtualNetworkIds">A list of references to virtual networks that resolve records in this DNS zone.</param>
        /// <return>The next stage of the definition.</return>
        DnsZone.Definition.IWithCreate DnsZone.Definition.IWithZoneType.WithPrivateAccess(IList<string> registrationVirtualNetworkIds, IList<string> resolutionVirtualNetworkIds)
        {
            return this.WithPrivateAccess(registrationVirtualNetworkIds, resolutionVirtualNetworkIds) as DnsZone.Definition.IWithCreate;
        }

        /// <summary>
        /// Sets the type of this zone to Public (default behavior).
        /// </summary>
        /// <return>The next stage of the definition.</return>
        DnsZone.Update.IUpdate DnsZone.Update.IWithZoneType.WithPublicAccess()
        {
            return this.WithPublicAccess() as DnsZone.Update.IUpdate;
        }

        /// <summary>
        /// Sets the type of this zone to Public (default behavior).
        /// </summary>
        /// <return>The next stage of the definition.</return>
        DnsZone.Definition.IWithCreate DnsZone.Definition.IWithZoneType.WithPublicAccess()
        {
            return this.WithPublicAccess() as DnsZone.Definition.IWithCreate;
        }
    }
}